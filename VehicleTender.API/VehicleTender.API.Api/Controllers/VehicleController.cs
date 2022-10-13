using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DTO.Vehicle;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        public VehicleController(ILogger<VehicleController> log)
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
            
            return Created(String.Empty,null);
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
