using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]

    public class ComissionController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        
        public ComissionController(ILogger<VehicleController> log)
        {
            _log = log;
           
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var LoginUserId = HttpContext.User.FindFirstValue("UserId");
            return Ok(LoginUserId);
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
