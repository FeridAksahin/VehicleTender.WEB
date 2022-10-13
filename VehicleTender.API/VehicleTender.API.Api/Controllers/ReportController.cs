using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        /// <summary>
        /// All Report actions will be done here.
        /// </summary>
        /// <returns></returns>
        private readonly ILogger<ReportController> _log;
        public ReportController(ILogger<ReportController> log)
        {
            _log = log;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Count()
        {

            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {

            return Created(String.Empty, null);
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {


            return NoContent();
        }
    }
}
