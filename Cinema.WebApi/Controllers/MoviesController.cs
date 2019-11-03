using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult Get()
        {
            return Ok(_dataRepository.GetAll());
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            return Ok(_dataRepository.Get(id));
        }

        // POST: api/Movies
        [HttpPost]
        public IActionResult Post([FromBody] Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Movies
        [HttpPut]
        public IActionResult Put([FromBody] Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _dataRepository.Delete(id);
        }
    }
}
