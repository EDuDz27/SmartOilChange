using System;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class ConsultaRepository
    {
        public ResultadoConsulta Consultar(int motorId)
        {
            var resultado = new ResultadoConsulta();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Buscar especificacao de oleo
                string sqlOleo = @"SELECT id, motor_id, viscosidade, especificacao, capacidade_litros
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
                                Id = reader.GetInt32(0),
                                MotorId = reader.GetInt32(1),
                                Viscosidade = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Especificacao = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                CapacidadeLitros = reader.IsDBNull(4) ? 0 : (decimal)reader.GetDouble(4)
                            };
                        }
                    }
                }

                // Buscar filtro OEM (original)
                string sqlFiltro = @"SELECT f.id, f.tipo, f.marca, f.numero_peca
                                     FROM FILTROS_OEM f
                                     INNER JOIN MOTORES_FILTROS_OEM mf ON f.id = mf.filtro_oem_id
                                     WHERE mf.motor_id = @motorId";

                using (var cmd = new SQLiteCommand(sqlFiltro, conn))
                {
                    cmd.Parameters.AddWithValue("@motorId", motorId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado.FiltroOriginal = new FiltroOriginal
                            {
                                Id = reader.GetInt32(0),
                                Tipo = reader.IsDBNull(1) ? TipoFiltro.Blindado : (TipoFiltro)Enum.Parse(typeof(TipoFiltro), reader.GetString(1)),
                                Marca = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                NumeroPeca = reader.IsDBNull(3) ? "" : reader.GetString(3)
                            };
                        }
                    }
                }

                // Buscar filtro equivalente
                if (resultado.FiltroOriginal != null)
                {
                    string sqlEquiv = @"SELECT fe.id, fe.marca, fe.numero_peca
                                        FROM FILTROS_EQUIVALENTES fe
                                        INNER JOIN OEM_FILTROS_EQUIVALENTES ofe ON fe.id = ofe.filtro_equivalente_id
                                        WHERE ofe.filtro_oem_id = @filtroOemId";

                    using (var cmd = new SQLiteCommand(sqlEquiv, conn))
                    {
                        cmd.Parameters.AddWithValue("@filtroOemId", resultado.FiltroOriginal.Id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultado.FiltroEquivalente = new FiltroEquivalente
                                {
                                    Id = reader.GetInt32(0),
                                    Marca = reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    NumeroPeca = reader.IsDBNull(2) ? "" : reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }

            return resultado;
        }
    }
}
