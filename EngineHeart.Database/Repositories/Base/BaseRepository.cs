using System.Data.SQLite;
using EngineHeart.Database.Context;

namespace EngineHeart.Database.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected static SQLiteConnection DbConnection() => DatabaseContext.Connection();
        protected abstract string Table { get; }

        protected string GetQuery => $"SELECT * FROM {Table} WHERE id = @id;";
        protected string GetAllQuery => $"SELECT * FROM {Table}";
    }
}