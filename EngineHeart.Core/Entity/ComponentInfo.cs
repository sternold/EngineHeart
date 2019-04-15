using EngineHeart.Core.Interfaces;

namespace EngineHeart.Core.Entity
{
    public class ComponentInfo : Base.Entity
    {
        public enum ComponentType
        {
            Feature,
            Defect
        }

        public ComponentType Type { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public bool Rated { get; set; }
    }
}
