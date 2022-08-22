using EntityWeb.Interface;
using EntityWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityWeb.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IService<Entity> _service;

        public EntityController(IService<Entity> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid guid)
        {
            var entry = await _service.Get(guid);
            return entry == null ? NotFound() : Ok(entry);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Entity entity)
        {
            await _service.Add(entity);
            return Ok();
        }
    }
}