using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityController : Controller
    {
        /// <summary>
        /// All Security actions will be done here.
        /// </summary>
        /// <returns></returns>
        private readonly ILogger<SecurityController> _hede;
        public SecurityController(ILogger<SecurityController> hede)
        {
            _hede = hede;
        }

        [HttpGet("")]
        public IActionResult GetIndex()

        {
            return Ok();
        }
        [HttpPut("")]
        public IActionResult PutIndex()
        {
            return Ok();
        }
        [HttpPost("")]
        public IActionResult PostIndex()
        {
            return Ok();
        }
        [HttpDelete("")]
        public IActionResult DeleteIndex()
        {
            return Ok();
        }
    }
}
