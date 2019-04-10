using System.Data.SQLite;
using EngineHeart.Database.Context;

namespace EngineHeart.Database.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected static SQLiteConnection DbConnection() => DatabaseContext.Connection();
        protected abstract string Table { get; }

        protected string GetQuery => string.Format("SELECT * FROM {0} WHERE id = @id;", Table);
        protected string GetAllQuery => string.Format("SELECT * FROM {0}", Table);
    }
}