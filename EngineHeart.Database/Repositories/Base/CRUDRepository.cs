using System.Collections.Generic;
using Dapper;
using EngineHeart.Core.Interfaces;
using EngineHeart.Database.Interfaces.Base;

namespace EngineHeart.Database.Repositories.Base
{
    public abstract class CRUDRepository<T> : BaseRepository, ICRUDRepository<T>
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
        public abstract int Insert(T entity);
        public abstract bool Update(T entity);
        public abstract bool Delete(T entity);
    }
}