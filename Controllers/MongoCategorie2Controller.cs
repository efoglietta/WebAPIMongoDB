using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo.Entities;
using Mongo.Services;

namespace Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoCategorie2Controller : ControllerBase
    {
        ICategorie2Service _serviceCategorie;

        public MongoCategorie2Controller(ICategorie2Service serviceCategorie)
        {
            _serviceCategorie = serviceCategorie;
        }

        // GET api/MongoProdottiController/61a6058e6c43f32854e51f51       
        [HttpGet("id")]
        public async Task<ActionResult<Categoria2>> Get(string id)
        {
            return await _serviceCategorie.GetCategoria(id);
        }
        [HttpGet]
        public async Task<ActionResult<List<Categoria2>>> Get()
        {
            return await _serviceCategorie.GetCategorie();
        }
        [HttpPost]
        public async void Post([FromBody] Categoria2 c)
        {
            await _serviceCategorie.CreateCategoria(c);
        }
    }
}
