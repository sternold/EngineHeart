using EngineHeart.Core.Entity;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class ComponentRepository : Base.QueryRepository<ComponentInfo>, IComponentRepository
    {
        private const string _table = "Components";
        protected override string Table => _table;
    }
}
