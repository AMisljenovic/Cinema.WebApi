using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;

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

        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets()
        {
            return Ok(await _dataRepository.GetAll());
        }

        [HttpGet("{movieId}/{hallId}")]
        public async Task<ActionResult<Ticket>> GetTicket(string movieId, string hallId)
        {
            if (!Guid.TryParse(movieId, out var parsedMovieId))
            {
                return BadRequest("Move id is not in valid format.");
            }

            if (!Guid.TryParse(hallId, out var parsedHallId))
            {
                return BadRequest("Hall id is not in valid format.");
            }

            return Ok(await _dataRepository.Get(movieId, hallId));
        }

        // PUT: api/Tickets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public async Task<IActionResult> PutTicket([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(ticket);
            return Ok();
        }

        // POST: api/Tickets
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<IActionResult> PostTicket(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(ticket);

            return Ok();
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{movieId}/{hallId}")]
        public async Task<ActionResult<Ticket>> DeleteTicket(string movieId, string hallId)
        {
            if (!Guid.TryParse(movieId, out var parsedMovieId))
            {
                return BadRequest("Move id is not in valid format.");
            }

            if (!Guid.TryParse(hallId, out var parsedHallId))
            {
                return BadRequest("Hall id is not in valid format.");
            }

            await _dataRepository.Delete(movieId, hallId);

            return Ok();
        }
    }
}
