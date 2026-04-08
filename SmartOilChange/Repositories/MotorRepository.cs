using System.Collections.Generic;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class MotorRepository
    {
        public List<Motor> GetByModeloId(int modeloId)
        {
            var motores = new List<Motor>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT mm.modelo_motor_id, m.motor_id, m.nome, mm.ano_inicio, mm.ano_fim
                               FROM MODELOS_MOTORES mm
                               INNER JOIN MOTORES m ON m.motor_id = mm.motor_id
                               WHERE mm.modelo_id = @modeloId
                               ORDER BY m.nome, mm.ano_inicio DESC";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@modeloId", modeloId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            motores.Add(new Motor
                            {
                                ModeloMotorId = reader.GetInt32(0),
                                MotorId = reader.GetInt32(1),
                                Nome = reader.GetString(2),
                                AnoInicio = reader.GetInt32(3),
                                AnoFim = reader.GetInt32(4)
                            });
                        }
                    }
                }
            }

            return motores;
        }
    }
}
