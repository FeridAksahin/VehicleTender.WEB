using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DTO.Vehicle;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehicleController : Controller
    {
        /// <summary>
        /// All Vehicle actions will be done here.
        /// </summary>
        /// <returns></returns>

        public VehicleController()
        {

        }

        [HttpGet("")]
        public IActionResult GetIndex([FromQuery] GetVehicleListInput input)
        {
            List<VehicleViewModel> vehicleList = new List<VehicleViewModel>
            {
                new VehicleViewModel{ ID = 1, CreatedDate = DateTime.Now, Bireysel = true, Name="BMW", Statu="Satışta", UserID = 1, VehicleModel = "3.20"},
                 new VehicleViewModel{ ID = 2, CreatedDate = DateTime.Now, Bireysel = true, Name="Mercedes", Statu="Satışta", UserID = 1, VehicleModel = "E250"}
            };
            return Ok(vehicleList);
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
