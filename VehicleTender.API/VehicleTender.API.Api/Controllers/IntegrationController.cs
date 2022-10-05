using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IntegrationController : Controller
    {
        /// <summary>
        /// All Integration actions will be done here.
        /// </summary>
        /// <returns></returns>

        private readonly ILogger<IntegrationController> _hede;
        public IntegrationController(ILogger<IntegrationController> hede)
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
