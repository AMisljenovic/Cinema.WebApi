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
    public class AnnouncedController : ControllerBase
    {
        private readonly IDataRepository<AnnouncedMovie> _dataRepository;

        public AnnouncedController(IDataRepository<AnnouncedMovie> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Announced
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnouncedMovie>>> Get()
        {
            return Ok(await _dataRepository.GetAll());
        }

        // GET: api/Announced/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnouncedMovie>> Get(string id)
        {
            return Ok(await _dataRepository.Get(id));
        }

        // POST: api/Announced
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AnnouncedMovie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Announced
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AnnouncedMovie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/Announced/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
