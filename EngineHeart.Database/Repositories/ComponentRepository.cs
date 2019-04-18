using EngineHeart.Core.Entity;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class ComponentRepository : Base.QueryRepository<ComponentInfo>, IComponentRepository
    {
        protected override string Table => "Components";
    }
}
