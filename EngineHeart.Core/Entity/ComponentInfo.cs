using EngineHeart.Core.Interfaces;

namespace EngineHeart.Core.Entity
{
    public class ComponentInfo : IEntity
    {
        public enum ComponentType
        {
            FEATURE,
            DEFECT
        }

        public int Id { get; set; }
        public ComponentType Type { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public bool Rated { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
