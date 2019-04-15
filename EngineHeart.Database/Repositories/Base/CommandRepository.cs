using Dapper;
using EngineHeart.Core.Interfaces;
using EngineHeart.Database.Interfaces.Base;

namespace EngineHeart.Database.Repositories.Base
{
    public abstract class CommandRepository<T> : BaseRepository, ICommandRepository<T>
        where T : class, IEntity
    {
        public abstract int Insert(T entity);
        public abstract bool Update(T entity);
        public abstract bool Delete(T entity);
    }
}
