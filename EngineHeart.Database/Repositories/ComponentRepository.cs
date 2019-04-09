using System.Collections.Generic;
using Dapper;
using EngineHeart.Core.Entity;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class ComponentRepository : CrudRepository<ComponentInfo>, IComponentRepository
    {
        private const string Table = "Components";
        private static string GetQuery => string.Format("SELECT * FROM {0} WHERE id = @id;", Table);
        private static string GetAllQuery => string.Format("SELECT * FROM {0}", Table);
        
        public override ComponentInfo Get(int id)
        {
            using (var connection = DbConnection())
            {
                return connection.QuerySingle<ComponentInfo>(GetQuery, new {id = id});
            }
        }

        public override IEnumerable<ComponentInfo> GetAll()
        {
            using (var connection = DbConnection())
            {
                return connection.Query<ComponentInfo>(GetAllQuery);
            }
        }

        public override int Insert(ComponentInfo entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(ComponentInfo entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
