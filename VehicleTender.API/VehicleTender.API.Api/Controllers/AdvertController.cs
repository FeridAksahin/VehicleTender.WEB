using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DataAccessLayer.Interface;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        private readonly IAdvertDAL _advertDAL;
        public AdvertController(ILogger<VehicleController> log, IAdvertDAL advertDAL)
        {
            _advertDAL = advertDAL;
            _log = log;
        }


        [HttpGet] // endUser için hemen araç al
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _advertDAL.GetAllCarAdverts());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
