﻿using EngineHeart.Core.Models;
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
    }
}