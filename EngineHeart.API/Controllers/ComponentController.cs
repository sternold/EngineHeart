using EngineHeart.Core.Models;
using EngineHeart.Database.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EngineHeart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/components")]
    public class ComponentController : CrudController<Component>
    {
        public ComponentController(IComponentRepository repository) : base(repository)
        {
        }
        
        [HttpPost]
        public override IActionResult Create([FromBody] Component entity)
        {
            return Unauthorized();
        }

        [HttpPatch]
        public override IActionResult Update([FromBody] Component entity)
        {
            return Unauthorized();
        }

        [HttpDelete("{id}")]
        public override IActionResult Delete(int id)
        {
            return Unauthorized();
        }
    }
}