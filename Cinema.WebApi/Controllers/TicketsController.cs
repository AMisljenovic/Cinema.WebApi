using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketRepository<Ticket> _dataRepository;

        public TicketsController(ITicketRepository<Ticket> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Tickets/5
        [HttpGet("{repertoryId}")]
        public async Task<IActionResult> Get(string repertoryId)
        {
            if (!Guid.TryParse(repertoryId, out var parsedId))
            {
                return BadRequest("Invalid repertory id");
            }

            return Ok( await _dataRepository.GetByRepertory(repertoryId));
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUser(string userId)
        {
            if (!Guid.TryParse(userId, out var parsedId))
            {
                return BadRequest("Invalid user id");
            }

            return Ok(await _dataRepository.GetByUser(userId));
        }

        // POST: api/Tickets
        [HttpPost]
        public async Task<IActionResult> Post(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(ticket);

            return Ok();
        }

        // PUT: api/Tickets/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(ticket);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{repertoryId}")]
        public async Task<IActionResult> Delete(string repertoryId)
        {
            if (!Guid.TryParse(repertoryId, out var parsedId))
            {
                return BadRequest("Invalid repertory id");
            }
            await _dataRepository.Delete(repertoryId);

            return Ok();
        }
    }
}
