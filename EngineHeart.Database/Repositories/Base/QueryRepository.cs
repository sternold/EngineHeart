using System.Collections.Generic;
using Dapper;
using EngineHeart.Core.Interfaces;
using EngineHeart.Database.Interfaces.Base;

namespace EngineHeart.Database.Repositories.Base
{
    public abstract class QueryRepository<T> : BaseRepository, IQueryRepository<T>
        where T : class, IEntity
    {
        public T Get(int id)
        {
            using (var connection = DbConnection()) return connection.QuerySingle<T>(GetQuery, new { id });
        }
        public IEnumerable<T> GetAll()
        {
            using (var connection = DbConnection()) return connection.Query<T>(GetAllQuery);
        }
    }
}
