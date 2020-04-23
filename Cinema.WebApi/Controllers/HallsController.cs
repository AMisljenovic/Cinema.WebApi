using System.Collections.Generic;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Post([FromBody] Hall value)
        {
            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Halls
        [HttpPut]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Put([FromBody] Hall value)
        {
            await _dataRepository.Update(value);

            return Ok();
        }

        // DELETE: api/Halls/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
