using EngineHeart.Core.Interfaces;

namespace EngineHeart.Core.Entity
{
    public class Component : IEntity
    {
        public int Id { get; set; }
        public ComponentInfo ComponentInfo { get; set; }
        public int Rating { get; set; }
    }
}
