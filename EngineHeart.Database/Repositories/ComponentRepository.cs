using System.Collections.Generic;
using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class ComponentRepository : CrudRepository<Component>, IComponentRepository
    {
        public override Component Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<Component> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public override int Insert(Component entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(Component entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(Component entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
