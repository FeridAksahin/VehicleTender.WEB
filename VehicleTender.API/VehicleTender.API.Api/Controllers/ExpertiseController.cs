using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExpertiseController : Controller
    {
        /// <summary>
        /// All Expertise actions will be done here.
        /// </summary>
        /// <returns></returns>
        /// 

        private readonly ILogger<ExpertiseController> _log;
        public ExpertiseController(ILogger<ExpertiseController> log)
        {
            _log = log;
        }

        [HttpGet("")]
        public IActionResult GetIndex()

        {
            _log.LogError("asdfasdfasd");
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
