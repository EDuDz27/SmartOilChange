using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class ServiceLogRepository
    {
        public void Add(ServiceLog serviceLog)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO SERVICE_LOGS 
                    (placa, oleo_utilizado, oleo_trocado, filtro_trocado, tampa_ok, 
                     luz_oleo_ok, vazamento_ok, nivel_oleo_ok, etiqueta_ok, sobra_oleo_ok, 
                     observacoes, created_at)
                    VALUES 
                    (@placa, @oleUtilizado, @oleoTrocado, @filtroTrocado, @tampaOk, 
                     @luzOleoOk, @vazamentoOk, @nivelOleoOk, @etiquetaOk, @sobraOleoOk, 
                     @observacoes, @criadoEm)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", serviceLog.Placa ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@oleUtilizado", serviceLog.OleoUtilizado ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@oleoTrocado", serviceLog.OleoTrocado ? 1 : 0);
                    cmd.Parameters.AddWithValue("@filtroTrocado", serviceLog.FiltroTrocado ? 1 : 0);
                    cmd.Parameters.AddWithValue("@tampaOk", serviceLog.TampaOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@luzOleoOk", serviceLog.LuzOleoOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@vazamentoOk", serviceLog.VazamentoOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@nivelOleoOk", serviceLog.NivelOleoOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@etiquetaOk", serviceLog.EtiquetaOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@sobraOleoOk", serviceLog.SobraOleoOk ? 1 : 0);
                    cmd.Parameters.AddWithValue("@observacoes", serviceLog.Observacoes ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@criadoEm", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ServiceLog> GetByPlaca(string placa)
        {
            var logs = new List<ServiceLog>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT logs_id, placa, oleo_utilizado, oleo_trocado, filtro_trocado, 
                              tampa_ok, luz_oleo_ok, vazamento_ok, nivel_oleo_ok, etiqueta_ok, 
                              sobra_oleo_ok, observacoes, created_at 
                              FROM SERVICE_LOGS 
                              WHERE placa LIKE @placa 
                              ORDER BY created_at DESC";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", "%" + placa + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logs.Add(new ServiceLog
                            {
                                LogsId = reader.GetInt32(0),
                                Placa = reader.IsDBNull(1) ? null : reader.GetString(1),
                                OleoUtilizado = reader.IsDBNull(2) ? null : reader.GetString(2),
                                OleoTrocado = reader.GetInt32(3) == 1,
                                FiltroTrocado = reader.GetInt32(4) == 1,
                                TampaOk = reader.GetInt32(5) == 1,
                                LuzOleoOk = reader.GetInt32(6) == 1,
                                VazamentoOk = reader.GetInt32(7) == 1,
                                NivelOleoOk = reader.GetInt32(8) == 1,
                                EtiquetaOk = reader.GetInt32(9) == 1,
                                SobraOleoOk = reader.GetInt32(10) == 1,
                                Observacoes = reader.IsDBNull(11) ? null : reader.GetString(11),
                                CriadoEm = reader.GetDateTime(12)
                            });
                        }
                    }
                }
            }

            return logs;
        }

        public List<ServiceLog> GetByPlacaPagenado(string placa, int offset, int limit)
        {
            var logs = new List<ServiceLog>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT logs_id, placa, oleo_utilizado, oleo_trocado, filtro_trocado, 
                              tampa_ok, luz_oleo_ok, vazamento_ok, nivel_oleo_ok, etiqueta_ok, 
                              sobra_oleo_ok, observacoes, created_at 
                              FROM SERVICE_LOGS ";

                if (!string.IsNullOrWhiteSpace(placa))
                {
                    sql += "WHERE placa LIKE @placa ";
                }

                sql += @"ORDER BY created_at DESC
                        LIMIT @limit OFFSET @offset";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(placa))
                    {
                        cmd.Parameters.AddWithValue("@placa", "%" + placa + "%");
                    }
                    cmd.Parameters.AddWithValue("@limit", limit);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logs.Add(new ServiceLog
                            {
                                LogsId = reader.GetInt32(0),
                                Placa = reader.IsDBNull(1) ? null : reader.GetString(1),
                                OleoUtilizado = reader.IsDBNull(2) ? null : reader.GetString(2),
                                OleoTrocado = reader.GetInt32(3) == 1,
                                FiltroTrocado = reader.GetInt32(4) == 1,
                                TampaOk = reader.GetInt32(5) == 1,
                                LuzOleoOk = reader.GetInt32(6) == 1,
                                VazamentoOk = reader.GetInt32(7) == 1,
                                NivelOleoOk = reader.GetInt32(8) == 1,
                                EtiquetaOk = reader.GetInt32(9) == 1,
                                SobraOleoOk = reader.GetInt32(10) == 1,
                                Observacoes = reader.IsDBNull(11) ? null : reader.GetString(11),
                                CriadoEm = reader.GetDateTime(12)
                            });
                        }
                    }
                }
            }

            return logs;
        }

        public int GetTotalCountByPlaca(string placa)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM SERVICE_LOGS";

                if (!string.IsNullOrWhiteSpace(placa))
                {
                    sql += " WHERE placa LIKE @placa";
                }

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(placa))
                    {
                        cmd.Parameters.AddWithValue("@placa", "%" + placa + "%");
                    }
                    return (int)(long)cmd.ExecuteScalar();
                }
            }
        }
    }
}
