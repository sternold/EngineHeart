using System.Collections.Generic;
using System.Linq;
using Dapper;
using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.Database.Repositories
{
    public class RobotRepository : CrudRepository<Robot>, IRobotRepository
    {
        private const string Robot = "Robots";
        private const string Child = "RobotComponents";
        private const string Component = "Components";

        private static string GetChildrenQuery =>
            $"SELECT * FROM {Child} INNER JOIN {Component} ON {Child}.componentid = {Component}.id WHERE {Child}.robotid = @id;";

        private static string GetQuery => $"SELECT * FROM {Robot} WHERE id = @id;";
        private static string GetAllQuery => $"SELECT * FROM {Robot}";

        private static string InsertQuery => $"INSERT INTO {Robot} " + "(name, player, originalpurpose, " +
                                             "realitycom, humancom, digicon, mechanicon, " +
                                             "dexterity, mobility, perception, reflexes, strength," +
                                             "durability, buffer, size, power) " + "VALUES " +
                                             "(@Name, @Player, @OriginalPurpose, " +
                                             "@RealityCom, @HumanCom, @DigiCon, @MechaniCon, " +
                                             "@Dexterity, @Mobility, @Perception, @Reflexes, @Strength," +
                                             "@Durability, @Buffer, @Size, @Power);";

        private static string UpdateQuery => $"UPDATE {Robot} SET" + "name = @Name, " + "player = @Player, " +
                                             "originalpurpose = @OriginalPlayer, " + "realitycom = @RealityCom, " +
                                             "humancom = @HumanCom, " + "digicon = @DigiCon, " +
                                             "mechanicon = @MechaniCon, " + "dexterity = @Dexterity, " +
                                             "mobility = @Mobility, " + "perception = @Perception, " +
                                             "reflexes = @Reflexes, " + "strength = @Strength, " +
                                             "durability = @Durability, " + "buffer = @Buffer, " + "size = @Size, " +
                                             "power = @Power " + "WHERE id = @Id;";

        public override Robot Get(int id)
        {
            using (var connection = DbConnection())
            {
                var result = connection.QuerySingle<Robot>(GetQuery, new {id = id});
                result.Components =
                    connection.Query<RobotComponent, Component, RobotComponent>(GetChildrenQuery,
                        (rcomponent, component) =>
                        {
                            rcomponent.Component = component;
                            return rcomponent;
                        }, new {id = id},
                        splitOn: "componentid");
                return result;
            }
        }

        public override IEnumerable<Robot> GetAll()
        {
            using (var connection = DbConnection())
            {
                foreach (var result in connection.Query<Robot>(GetAllQuery).Distinct())
                {
                    result.Components =
                        connection.Query<RobotComponent, Component, RobotComponent>(GetChildrenQuery,
                            (rcomponent, component) =>
                            {
                                rcomponent.Component = component;
                                return rcomponent;
                            }, new {id = result.Id});
                    yield return result;
                }
            }
        }

        public override int Insert(Robot entity)
        {
            using (var connection = DbConnection())
            {
                return connection.Execute(InsertQuery, entity);
            }
        }

        public override bool Update(Robot entity)
        {
            using (var connection = DbConnection())
            {
                return connection.Execute(UpdateQuery, entity) > 0;
            }
        }

        public override bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}