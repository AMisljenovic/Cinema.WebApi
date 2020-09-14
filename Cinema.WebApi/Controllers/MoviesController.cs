using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
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
        public async Task<IEnumerable<Movie>> Get()
        {
            return await _dataRepository.GetAll();
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Movie>> Get(string id)
        {
            return Ok( await _dataRepository.Get(id));
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Post([FromBody] Movie value)
        {
            await _dataRepository.Add(value);

            return Ok();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Put([FromBody] Movie value)
        {
            await _dataRepository.Update(value);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
