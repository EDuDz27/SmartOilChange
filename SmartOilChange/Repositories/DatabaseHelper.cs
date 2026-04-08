using System;
using System.Data.SQLite;
using System.IO;

namespace SmartOilChange.Repositories
{
    internal class DatabaseHelper
    {
        private static readonly string DatabaseFolder =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database"));

        private static readonly string DatabasePath =
            Path.Combine(DatabaseFolder, "SmartOilChange.db");

        private static readonly string ConnectionString =
            "Data Source=" + DatabasePath + ";Version=3;Foreign Keys=True;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            if (!Directory.Exists(DatabaseFolder))
            {
                Directory.CreateDirectory(DatabaseFolder);
            }

            if (!File.Exists(DatabasePath) || new FileInfo(DatabasePath).Length == 0)
            {
                RecreateDatabase();
                return;
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                if (!SchemaValido(connection))
                {
                    connection.Close();
                    RecreateDatabase();
                }
            }
        }

        private static bool SchemaValido(SQLiteConnection connection)
        {
            return TabelaComColunaExiste(connection, "MARCAS", "marca_id")
                && TabelaComColunaExiste(connection, "MODELOS", "modelo_id")
                && TabelaComColunaExiste(connection, "MOTORES", "motor_id")
                && TabelaComColunaExiste(connection, "MODELOS_MOTORES", "modelo_motor_id")
                && TabelaComColunaExiste(connection, "MODELOS_MOTORES", "ano_inicio")
                && TabelaComColunaExiste(connection, "ESPECIFICACOES_OLEO", "norma_api")
                && TabelaComColunaExiste(connection, "ESPECIFICACOES_OLEO", "norma_acea")
                && TabelaComColunaExiste(connection, "FILTROS", "filtro_id")
                && TabelaComColunaExiste(connection, "MOTOR_FILTROS", "modelo_motor_id");
        }

        private static bool TabelaComColunaExiste(SQLiteConnection connection, string tabela, string coluna)
        {
            using (var cmd = new SQLiteCommand("PRAGMA table_info(" + tabela + ")", connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (string.Equals(reader[1].ToString(), coluna, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void RecreateDatabase()
        {
            if (File.Exists(DatabasePath))
            {
                File.Delete(DatabasePath);
            }

            SQLiteConnection.CreateFile(DatabasePath);

            using (var connection = GetConnection())
            {
                connection.Open();
                ExecuteSqlFile(connection, Path.Combine(DatabaseFolder, "schema.sql"));
                ExecuteSqlFile(connection, Path.Combine(DatabaseFolder, "seed.sql"));
            }
        }

        private static void ExecuteSqlFile(SQLiteConnection connection, string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string sql = File.ReadAllText(filePath);

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
