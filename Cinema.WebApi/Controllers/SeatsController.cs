using System.Collections.Generic;
using System.Threading.Tasks;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        private readonly ISeatRepository<Seat> _dataRepository;

        public SeatsController(ISeatRepository<Seat> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Seats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seat>>> Get()
        {
            return Ok(await _dataRepository.GetAll());
        }

        // GET: api/Seats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Seat>>> Get(string id)
        {
            return Ok(await _dataRepository.Get(id));
        }      

        // POST: api/Seats
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Seat value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Seats
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Seat value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/Seats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
