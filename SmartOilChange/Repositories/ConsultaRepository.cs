using System;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class ConsultaRepository
    {
        public ResultadoConsulta Consultar(int modeloMotorId, int motorId)
        {
            var resultado = new ResultadoConsulta();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sqlOleo = @"SELECT oleo_id, motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes
                                   FROM ESPECIFICACOES_OLEO
                                   WHERE motor_id = @motorId";

                using (var cmd = new SQLiteCommand(sqlOleo, conn))
                {
                    cmd.Parameters.AddWithValue("@motorId", motorId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado.Oleo = new EspecificacaoOleo
                            {
                                OleoId = reader.GetInt32(0),
                                MotorId = reader.GetInt32(1),
                                Viscosidade = reader.GetString(2),
                                NormaApi = reader.GetString(3),
                                NormaAcea = reader.GetString(4),
                                CapacidadeLitros = Convert.ToDecimal(reader.GetDouble(5)),
                                Observacoes = reader.GetString(6)
                            };
                        }
                    }
                }

                string sqlFiltros = @"SELECT f.tipo, f.marca, f.numero_peca
                                      FROM MOTOR_FILTROS mf
                                      INNER JOIN FILTROS f ON f.filtro_id = mf.filtro_id
                                      WHERE mf.modelo_motor_id = @modeloMotorId
                                      ORDER BY f.tipo, f.marca, f.numero_peca";

                using (var cmd = new SQLiteCommand(sqlFiltros, conn))
                {
                    cmd.Parameters.AddWithValue("@modeloMotorId", modeloMotorId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultado.Filtros.Add(new Filtro
                            {
                                Tipo = Capitalizar(reader.GetString(0)),
                                Marca = reader.GetString(1),
                                NumeroPeca = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return resultado;
        }

        private static string Capitalizar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return string.Empty;
            return char.ToUpper(valor[0]) + valor.Substring(1).ToLower();
        }
    }
}
