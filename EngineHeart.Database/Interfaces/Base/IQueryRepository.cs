using System.Collections.Generic;

namespace EngineHeart.Database.Interfaces.Base
{
    public interface IQueryRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
