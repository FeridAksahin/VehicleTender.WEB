using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DataAccessLayer.Concrete;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        IndividualVehicleDal individualVehicleDal = new IndividualVehicleDal();
        public AdvertController(ILogger<VehicleController> log)
        {
            _log = log;
        }


        [HttpGet] // endUser için hemen araç al
        public async Task<IActionResult> GetAll()
        {
            await individualVehicleDal.GetAllCarAdverts();
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
