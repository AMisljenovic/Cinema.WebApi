using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
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

        [HttpGet("{repertoryId}/{userId}")]
        public async Task<IActionResult> GetByRepertoryAndUser(string repertoryId, string userId)
        {
            if (!Guid.TryParse(userId, out var parsedId))
            {
                return BadRequest("Invalid user id");
            }

            if (!Guid.TryParse(userId, out var parsedUserId))
            {
                return BadRequest("Invalid user id");
            }

            return Ok(await _dataRepository.GetByRepertoryAndUser(repertoryId, userId));
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
        public async Task<IActionResult> Post(List<Ticket> tickets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(tickets);

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
