using System.Collections.Generic;
using System.Data.SQLite;

namespace SmartOilChange.Repositories
{
    internal class AnoRepository
    {
        public List<int> GetByMotorId(int motorId)
        {
            var anos = new List<int>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ano_inicio, ano_fim FROM MOTORES WHERE id = @motorId";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@motorId", motorId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int anoInicio = reader.GetInt32(0);
                            int anoFim = reader.GetInt32(1);

                            for (int ano = anoFim; ano >= anoInicio; ano--)
                            {
                                anos.Add(ano);
                            }
                        }
                    }
                }
            }

            return anos;
        }
    }
}
