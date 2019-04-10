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
        public static string File => Environment.CurrentDirectory + "\\" + Name;

        public static bool Exists => System.IO.File.Exists(DatabaseContext.File);
        public static SQLiteConnection Connection() => new SQLiteConnection("Data Source=" + DatabaseContext.File);

        public static void Create()
        {
            try
            {
                EnsureDeleted();
                SQLiteConnection.CreateFile(Name);

                //Database generation scripts
                var sqlScripts = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Scripts";
                var sqlSchema = System.IO.File.ReadAllText(sqlScripts + "\\dbschema.sql");
                var sqlSeed = System.IO.File.ReadAllText(sqlScripts + "\\seed.sql");

                using (var connection = Connection())
                {
                    connection.Open();
                    connection.Execute(sqlSchema);
                    connection.Execute(sqlSeed);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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