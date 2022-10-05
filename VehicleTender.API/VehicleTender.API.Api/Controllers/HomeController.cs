using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Common.Enums;



namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {
        /// <summary>
        /// All Base actions will be done here.
        /// </summary>
        /// <returns></returns>

        private readonly ILogger<HomeController> _hede;
        public HomeController(ILogger<HomeController> hede)
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
