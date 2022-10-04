using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Common.Enums;
using VehicleTender.API.DTO.LogDTOs;
using VehicleTender.API.Logs;

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

        private readonly ILoggerManager _logger;
        public HomeController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult GetIndex()

        {
            _logger.Log(new LogDTO() { Date = DateTime.Now,Message="fasdfasd", LogProcess = LogProcess.Info,UserId=null });
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
