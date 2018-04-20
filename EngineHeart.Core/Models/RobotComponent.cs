using EngineHeart.Core.Interfaces;

namespace EngineHeart.Core.Models
{
    public class RobotComponent : IModel
    {
        public int Id { get; set; }
        public Component Component { get; set; }
        public int Rating { get; set; }
    }
}
