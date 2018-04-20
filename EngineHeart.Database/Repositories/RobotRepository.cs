using System.Collections.Generic;
using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class RobotRepository : CrudRepository<Robot>, IRobotRepository
    {
        public override Robot Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<Robot> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public override int Insert(Robot entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(Robot entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(Robot entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
