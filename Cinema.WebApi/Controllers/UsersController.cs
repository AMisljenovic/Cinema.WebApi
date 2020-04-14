using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository<User> _dataRepository;

        public UsersController(IUsersRepository<User> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Users/5
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if ((string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password)) &&
                (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password)))
            {
                return BadRequest("Please enter username or email and password.");
                
            }

            var dbUser = await _dataRepository.Get(user.Email, user.Username, user.Password);

            if (dbUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dbUser.Username),
                    new Claim(ClaimTypes.Email, dbUser.Email),
                    new Claim(ClaimTypes.Role, dbUser.Role),
                    new Claim(ClaimTypes.DateOfBirth, dbUser.Birthday)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "User identity");
                var userPrincipal = new ClaimsPrincipal(new[] { claimsIdentity });

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal);

                return NoContent();
            }

            return Unauthorized("Invalid username(email) or password");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return NoContent();
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
        [Authorize(Roles = "Administrator")]
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
        [Authorize(AuthenticationSchemes = Constants.CookieAuthScheme)]
        public async Task<IActionResult> Delete(string id)
        {
            await _dataRepository.Delete(id);

            return Ok();
        }
    }
}
