using System.Collections.Generic;

namespace EngineHeart.Database.Interfaces.Base
{
    public interface IQueryRepository<out T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
