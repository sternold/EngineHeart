using EngineHeart.Database.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EngineHeart.API.Controllers
{
    public abstract class CrudController<T> : Controller
    {
        protected ICrudRepository<T> Repository;

        public CrudController(ICrudRepository<T> repository)
        {
            Repository = repository;
        }
        
        [HttpPost]
        public virtual IActionResult Create([FromBody] T entity)
        {
            if (!TryValidateModel(entity))
            {
                return BadRequest("Incomplete or incorrect data has been provided.");
            }

            var id = Repository.Insert(entity);
            return Get(id);
        }

        
        [HttpGet]
        public virtual IActionResult GetAll()
        {
            return new ObjectResult(Repository.GetAll());
        }

        
        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            var entity = Repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }

            return new ObjectResult(entity);
        }
        
        [HttpPatch]
        public virtual IActionResult Update([FromBody] T entity)
        {
            if (!TryValidateModel(entity))
            {
                return BadRequest("Incomplete or incorrect data has been provided.");
            }

            if (Repository.Update(entity))
            {
                return Ok(entity);
            }

            return BadRequest();
        }
        
        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            if (Repository.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}