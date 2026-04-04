using System.Collections.Generic;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class ModeloRepository
    {
        public List<Modelo> GetByMarcaId(int marcaId)
        {
            var modelos = new List<Modelo>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, marca_id, nome FROM MODELOS WHERE marca_id = @marcaId ORDER BY nome";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@marcaId", marcaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelos.Add(new Modelo
                            {
                                Id = reader.GetInt32(0),
                                MarcaId = reader.GetInt32(1),
                                Nome = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return modelos;
        }
    }
}
