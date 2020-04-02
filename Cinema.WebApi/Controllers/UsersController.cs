using System.Collections.Generic;
using System.Threading.Tasks;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository<User> _dataRepository;

        public UsersController(IUsersRepository<User> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Users/5
        [HttpGet]
        public async Task<IActionResult> Get([FromBody] User user)
        {
            if ((string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password)) &&
                (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password)))
            {
                return BadRequest("Please enter username or email and password.");
                
            }

            return Ok(await _dataRepository.Get(user.Email, user.Username, user.Password));
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Add(value);

            return Ok();
        }

        // PUT: api/Users
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] User value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.Update(value);

            return Ok();
        }

        // PUT: api/Users/promote
        [HttpPut("promote")]
        public async Task<IActionResult> Put([FromBody] User value, [FromQuery] string userName, [FromQuery] string newRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _dataRepository.UpdateRole(value, userName, newRole);

            return Ok();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
