using System.Collections.Generic;
using Dapper;
using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class RobotRepository : CrudRepository<Robot>, IRobotRepository
    {
        private const string Table = "Robots";
        private static string GetQuery => string.Format("SELECT * FROM {0} WHERE id = @id;", Table);
        private static string GetAllQuery => string.Format("SELECT * FROM {0}", Table);
        
        public override Robot Get(int id)
        {
            using (var connection = DbConnection())
            {
                return connection.QuerySingle<Robot>(GetQuery, new {id = id});
            }
        }

        public override IEnumerable<Robot> GetAll()
        {
            using (var connection = DbConnection())
            {
                return connection.Query<Robot>(GetAllQuery);
            }
        }

        public override int Insert(Robot entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(Robot entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
