using System.Collections.Generic;
using System.Data.SQLite;
using SmartOilChange.Models;

namespace SmartOilChange.Repositories
{
    internal class MarcaRepository
    {
        public List<Marca> GetAll()
        {
            var marcas = new List<Marca>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT marca_id, nome FROM MARCAS ORDER BY nome";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marcas.Add(new Marca
                        {
                            MarcaId = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        });
                    }
                }
            }

            return marcas;
        }
    }
}
