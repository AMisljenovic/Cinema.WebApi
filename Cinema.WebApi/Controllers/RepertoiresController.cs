using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Cors;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
    [ApiController]
    public class RepertoiresController : ControllerBase
    {
        private readonly IRepertoryRepository<Repertory> _dataRepository;

        public RepertoiresController(IRepertoryRepository<Repertory> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Repertory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Repertory>>> GetAll()
        {
            return Ok(await _dataRepository.GetAll());
        }

        [HttpGet("{movieId}")]
        public async Task<ActionResult<IEnumerable<Repertory>>> GetByMovie(string movieId)
        {
            return Ok(await _dataRepository.GetByMovie(movieId));
        }

        [HttpGet("repertory/{repertoryId}")]
        public async Task<ActionResult<Repertory>> Get(string repertoryId)
        {
            return Ok(await _dataRepository.GetById(repertoryId));
        }

        // PUT: api/Repertory/5
        [HttpPut]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Put([FromBody] Repertory repertory)
        {
            await _dataRepository.Update(repertory);
            return Ok();
        }

        // POST: api/Repertory
        [HttpPost]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Post(Repertory repertory)
        {
            await _dataRepository.Add(repertory);

            return Ok();
        }

        // DELETE: api/Repertory/5
        [HttpDelete("{movieId}/{hallId}")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult<Repertory>> Delete(string movieId, string hallId)
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
