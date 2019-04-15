using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using Dapper;

namespace EngineHeart.Database.Context
{
    public static class DatabaseContext
    {
        public const string Name = "db.sqlite";
        public static string File => $"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}{Name}";

        public static bool Exists => System.IO.File.Exists(DatabaseContext.File);
        public static SQLiteConnection Connection() => new SQLiteConnection($"Data Source={DatabaseContext.File}");

        public static void Create()
        {
            EnsureDeleted();
            GetSqlScripts(out var sqlSchema, out var sqlSeed);
            GenerateDb(sqlSchema, sqlSeed);
        }

        public static void CreateIfNotExist()
        {
            if (DatabaseContext.Exists) return;
            GetSqlScripts(out var sqlSchema, out var sqlSeed);
            GenerateDb(sqlSchema, sqlSeed);
        }

        private static void GetSqlScripts(out string schema, out string seed)
        {
            var sqlScripts =
                $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}Scripts";
            schema = System.IO.File.ReadAllText($"{sqlScripts}{Path.DirectorySeparatorChar}dbschema.sql");
            seed = System.IO.File.ReadAllText($"{sqlScripts}{Path.DirectorySeparatorChar}seed.sql");
        }

        private static void GenerateDb(string schema, string seed = "")
        {
            try
            {
                SQLiteConnection.CreateFile(Name);
                using (var connection = Connection())
                {
                    connection.Open();
                    connection.Execute(schema);
                    connection.Execute(seed);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                EnsureDeleted();
                throw;
            }
        }

        public static void EnsureDeleted()
        {
            if (DatabaseContext.Exists)
            {
                System.IO.File.Delete(DatabaseContext.File);
            }
        }
    }
}