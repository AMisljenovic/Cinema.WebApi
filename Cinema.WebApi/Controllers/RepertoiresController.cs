using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Cors;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;

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

        //[HttpGet("{movieId}/{hallId}")]
        //public async Task<ActionResult<Repertory>> Get(string movieId, string hallId)
        //{
        //    if (!Guid.TryParse(movieId, out var parsedMovieId))
        //    {
        //        return BadRequest("Move id is not in valid format.");
        //    }

        //    if (!Guid.TryParse(hallId, out var parsedHallId))
        //    {
        //        return BadRequest("Hall id is not in valid format.");
        //    }

        //    return Ok(await _dataRepository.Get(movieId, hallId));
        //}

        [HttpGet("repertory/{repertoryId}")]
        public async Task<ActionResult<Repertory>> Get(string repertoryId)
        {
            if (!Guid.TryParse(repertoryId, out var parserepertoryId))
            {
                return BadRequest("Repertory id is not in valid format.");
            }

            return Ok(await _dataRepository.GetById(repertoryId));
        }

        // PUT: api/Repertory/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Repertory repertory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(repertory);
            return Ok();
        }

        // POST: api/Repertory
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<IActionResult> Post(Repertory repertory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(repertory);

            return Ok();
        }

        // DELETE: api/Repertory/5
        [HttpDelete("{movieId}/{hallId}")]
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
