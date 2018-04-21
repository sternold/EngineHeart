using System.Data.SQLite;
using EngineHeart.Database.Context;

namespace EngineHeart.Database.Repositories
{
    public abstract class BaseRepository
    {
        protected static SQLiteConnection DbConnection() => DatabaseContext.Connection();
    }
}