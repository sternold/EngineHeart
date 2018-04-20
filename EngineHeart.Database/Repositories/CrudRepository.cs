using System.Collections.Generic;
using EngineHeart.Core.Interfaces;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public abstract class CrudRepository<T> : BaseRepository, ICrudRepository<T>
        where T : class, IModel
    {
        public abstract T Get(int id);
        public abstract IEnumerable<T> GetAll();
        public abstract int Insert(T entity);
        public abstract bool Update(T entity);
        public abstract bool Delete(T entity);
    }
}