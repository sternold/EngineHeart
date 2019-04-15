namespace EngineHeart.Database.Interfaces.Base
{
    public interface ICommandRepository<in T>
    {
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
