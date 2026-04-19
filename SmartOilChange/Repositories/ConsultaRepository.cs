using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class ConsultaRepository
    {
        public ResultadoConsulta Consultar(List<int> modelosMotoresIds)
        {
            var resultado = new ResultadoConsulta();

            if (modelosMotoresIds == null || modelosMotoresIds.Count == 0)
            {
                return resultado;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var parametros = new List<string>();
                for (int i = 0; i < modelosMotoresIds.Count; i++)
                {
                    parametros.Add("@id" + i);
                }

                string inClause = string.Join(",", parametros);

                string sqlOleo = "SELECT oleo_id, modelo_motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes " +
                                 "FROM ESPECIFICACOES_OLEO " +
                                 "WHERE modelo_motor_id IN (" + inClause + ") " +
                                 "ORDER BY oleo_id LIMIT 1";

                using (var cmd = new SQLiteCommand(sqlOleo, conn))
                {
                    for (int i = 0; i < modelosMotoresIds.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(parametros[i], modelosMotoresIds[i]);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado.Oleo = new EspecificacaoOleo
                            {
                                OleoId = reader.GetInt32(0),
                                ModeloMotorId = reader.GetInt32(1),
                                Viscosidade = reader.GetString(2),
                                NormaApi = reader.GetString(3),
                                NormaAcea = reader.GetString(4),
                                CapacidadeLitros = reader.IsDBNull(5) ? 0m : Convert.ToDecimal(reader.GetDouble(5)),
                                Observacoes = reader.GetString(6)
                            };
                        }
                    }
                }

                string sqlFiltros = "SELECT DISTINCT f.tipo, f.marca, f.numero_peca " +
                                    "FROM MOTOR_FILTROS mf " +
                                    "INNER JOIN FILTROS f ON f.filtro_id = mf.filtro_id " +
                                    "WHERE mf.modelo_motor_id IN (" + inClause + ") " +
                                    "ORDER BY f.tipo, f.marca, f.numero_peca";

                using (var cmd = new SQLiteCommand(sqlFiltros, conn))
                {
                    for (int i = 0; i < modelosMotoresIds.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(parametros[i], modelosMotoresIds[i]);
                    }

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
