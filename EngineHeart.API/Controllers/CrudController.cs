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
    }
}