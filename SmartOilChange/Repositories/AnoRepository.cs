using System.Collections.Generic;
using System.Data.SQLite;

namespace SmartOilChange.Repositories
{
    internal class AnoRepository
    {
        public List<int> GetByModeloId(int modeloId)
        {
            var anos = new SortedSet<int>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ano_inicio, ano_fim FROM MODELOS_MOTORES WHERE modelo_id = @modeloId";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@modeloId", modeloId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int anoInicio = reader.GetInt32(0);
                            int anoFim = reader.GetInt32(1);

                            for (int ano = anoInicio; ano <= anoFim; ano++)
                            {
                                anos.Add(ano);
                            }
                        }
                    }
                }
            }

            return new List<int>(anos);
        }
    }
}
