using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/checks")]
    [AllowAnonymous]
    [ApiController]
    public class ChecksController : ControllerBase
    {
        [HttpGet]
        [Route("health")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
