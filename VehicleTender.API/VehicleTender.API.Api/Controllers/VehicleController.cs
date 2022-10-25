using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Api.Models;
using VehicleTender.API.Common.CustomHTTPResponse;
using VehicleTender.API.DataAccessLayer.Concrete;
using VehicleTender.API.DTO.EndUserDTO.VM.Account;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;
using VehicleTender.API.DTO.EndUserDTO.VM.Vehicle;
using VehicleTender.API.DTO.Vehicle;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
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
        public async Task<IActionResult> Post(PostingSalesVM vm)
        {
            PostingVehicleDal postingVehicleDal = new PostingVehicleDal();

            if (postingVehicleDal.AddPostingvehicle(vm))
            {
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpGet]
        public async Task<List<CarListVM>> Create()
        {
            //var s = HttpContext.Request.Headers.Values;
            CarListVM ccdddd = new CarListVM();
            ccdddd.BodyTypeId = 3;
            List<CarListVM> gg = new List<CarListVM>();
            gg.Add(ccdddd);
            return gg;
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
