using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using Dapper;

namespace EngineHeart.Database.Repositories
{
    public abstract class BaseRepository
    {
        protected static string DbName => "db.sqlite";
        protected static string DbFile => Environment.CurrentDirectory + "\\" + DbName;
        protected static SQLiteConnection DbConnection() => new SQLiteConnection("Data Source=" + DbFile);

        private static string SqlScripts => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Scripts";
        private static string SqlSchema => File.ReadAllText(SqlScripts + "\\dbschema.sql");
        private static string SqlSeed => File.ReadAllText(SqlScripts + "\\seed.sql");

        public static bool DbExists => File.Exists(DbFile);

        public static void TryCreateDatabase()
        {
            try
            {
                EnsureDatabaseDeleted();
                SQLiteConnection.CreateFile(DbName);

                using (var connection = DbConnection())
                {
                    connection.Open();
                    connection.Execute(SqlSchema);
                    connection.Execute(SqlSeed);
                }
            }
            catch (Exception e)
            {
                EnsureDatabaseDeleted();
            }
        }

        public static void EnsureDatabaseDeleted()
        {
            if (DbExists)
            {
                File.Delete(DbFile);
            }
        }
    }
}
