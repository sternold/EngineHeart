using System.Collections.Generic;

namespace EngineHeart.Database.Interfaces
{
    public interface ICrudRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}