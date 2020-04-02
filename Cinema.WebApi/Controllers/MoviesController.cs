using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IDataRepository<Movie> _dataRepository;

        public MoviesController(IDataRepository<Movie> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            return Ok( await _dataRepository.GetAll());
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Movie>> Get(string id)
        {
            return Ok( await _dataRepository.Get(id));
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Movies
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
