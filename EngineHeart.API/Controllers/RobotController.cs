using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;

namespace EngineHeart.API.Controllers
{
    public class RobotController : CrudController<Robot>
    {
        public RobotController(IRobotRepository repository) : base(repository)
        {
            
        }
    }
}