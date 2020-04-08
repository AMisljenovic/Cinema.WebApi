using System.Collections.Generic;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
    [ApiController]
    public class HallsController : ControllerBase
    {
        private readonly IDataRepository<Hall> _dataRepository;

        public HallsController(IDataRepository<Hall> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Halls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hall>>> Get()
        {
            return Ok(await _dataRepository.GetAll());
        }

        // GET: api/Halls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hall>> Get(string id)
        {
            return Ok(await _dataRepository.Get(id));
        }

        // POST: api/Halls
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Hall value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Halls
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Hall value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/Halls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
