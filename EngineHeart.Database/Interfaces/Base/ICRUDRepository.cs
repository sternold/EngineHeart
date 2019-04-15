namespace EngineHeart.Database.Interfaces.Base
{
    public interface ICRUDRepository<T> : IQueryRepository<T>, ICommandRepository<T> { }
}