using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EngineHeart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/robots")]
    public class RobotController : CrudController<Robot>
    {
        public RobotController(IRobotRepository repository) : base(repository)
        {
            
        }
        
        [HttpDelete("{id}")]
        public override IActionResult Delete(int id)
        {
            return Unauthorized();
        }
    }
}