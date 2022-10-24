using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DataAccessLayer.Concrete;
using VehicleTender.API.DTO.AdminDTO.Models.Tender;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TenderController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        TenderDal tenderDal = new TenderDal();
        public TenderController(ILogger<VehicleController> log)
        {
            _log = log;
        }


        [HttpGet]
        public async Task<List<GetTenderDTO>> GetAll()
        {
            return tenderDal.GetAllTenderForAdminUI();
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
