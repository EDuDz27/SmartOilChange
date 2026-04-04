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
                string sql = @"SELECT m.id, m.nome_motor, m.ano_inicio, m.ano_fim
                               FROM MOTORES m
                               INNER JOIN MODELOS_MOTORES mm ON m.id = mm.motor_id
                               WHERE mm.modelo_id = @modeloId
                               ORDER BY m.nome_motor";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@modeloId", modeloId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            motores.Add(new Motor
                            {
                                Id = reader.GetInt32(0),
                                NomeMotor = reader.GetString(1),
                                AnoInicio = reader.GetInt32(2),
                                AnoFim = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return motores;
        }
    }
}
