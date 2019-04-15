using EngineHeart.Core.Interfaces;
using System.ComponentModel;

namespace EngineHeart.Core.Entity.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
