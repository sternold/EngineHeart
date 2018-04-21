using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class ComponentRepository : CrudRepository<Component>, IComponentRepository
    {
        private const string Table = "Components";
        private static string GetQuery => string.Format("SELECT * FROM {0} WHERE id = @id;", Table);
        private static string GetAllQuery => string.Format("SELECT * FROM {0}", Table);
        
        public override Component Get(int id)
        {
            using (var connection = DbConnection())
            {
                return connection.QuerySingle<Component>(GetQuery, new {id = id});
            }
        }

        public override IEnumerable<Component> GetAll()
        {
            using (var connection = DbConnection())
            {
                return connection.Query<Component>(GetAllQuery);
            }
        }

        public override int Insert(Component entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(Component entity)
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
