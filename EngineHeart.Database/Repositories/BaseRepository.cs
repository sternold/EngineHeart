using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using Dapper;

namespace EngineHeart.Database.Repositories
{
    public abstract class BaseRepository
    {
        protected SQLiteConnection DbConnection() => Database.Connection();
        
        public static class Database
        {
            public static string Name => "db.sqlite";
            public static string File => Environment.CurrentDirectory + "\\" + Name;
            public static SQLiteConnection Connection() => new SQLiteConnection("Data Source=" + Database.File);

            public static bool Exists => System.IO.File.Exists(Database.File);

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
                }
            }

            public static void EnsureDeleted()
            {
                if (Database.Exists)
                {
                    System.IO.File.Delete(Database.File);
                }
            }
        }
    }
}