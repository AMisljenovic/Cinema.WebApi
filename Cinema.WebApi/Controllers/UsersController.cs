using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Request;
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
        [HttpPost("signin")]
        public async Task<IActionResult> Login([FromBody] UserRequestModel user)
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
                };

                var claimsIdentity = new ClaimsIdentity(claims, "User identity");
                var userPrincipal = new ClaimsPrincipal(new[] { claimsIdentity });

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.AddHours(1)
                });

                return Ok(dbUser);
            }

            return Unauthorized("Invalid username(email) or password");
        }

        [HttpPost("signout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return NoContent();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User value)
        {
            var response = await _dataRepository.Add(value, "User");

            if (response.Length > 0)
            {
                return Conflict(response);
            }

            return Ok(response);
        }

        [HttpPost("admin/{adminSecret}")]
        public async Task<IActionResult> PostAdmin([FromBody] User value, string adminSecret)
        {
            if (!IsSecretKeyValid(adminSecret))
            {
                return Unauthorized("Secret key invalid");
            }   

            var response = await _dataRepository.Add(value, "Administrator");

            if (response.Length > 0)
            {
                return Conflict(response);
            }

            return Ok(response);
        }

        // PUT: api/Users
        [HttpPut]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Put([FromBody] PostUserRequestModel value)
        {
            var user = new User
            {
                Name = value.Name,
                Email = value.Email,
                Password = value.NewPassword,
                Surname = value.Surname,
                Username = value.Username
            };

            var oldPassword = value.Password;

            var response = await _dataRepository.Update(user, oldPassword);

            if (response == DbStatusCode.PasswordDoesntMatch)
            {
                return Unauthorized(DbStatusCode.PasswordDoesntMatch.ToString());
            }
            else if (response == DbStatusCode.EmailInUse)
            {
                return Conflict();
            }

            return Ok("Updated");
        }


        // DELETE: api/Users/5
        [HttpDelete]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Delete(UserRequestModel user)
        {
            var dbUser = new User
            {
                Email = user.Email,
                Username = user.Username,
                Password = user.Password
            };

            var response = await _dataRepository.Delete(dbUser);

            if (response == DbStatusCode.PasswordDoesntMatch)
            {
                return Unauthorized(DbStatusCode.PasswordDoesntMatch.ToString());
            }

            return Ok(DbStatusCode.Executed.ToString());
        }

        private bool IsSecretKeyValid(string adminSecret)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(adminSecret);
            return Constants.secretKey == Convert.ToBase64String(plainTextBytes);
        }
    }
}
