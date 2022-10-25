using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.DataAccessLayer.Concrete;
using VehicleTender.API.DTO.AdminDTO.Models.Tender;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;
using VehicleTender.API.DTO.EndUserDTO.VM.Tender;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TenderController : ControllerBase
    {
        private readonly ILogger<VehicleController> _log;
        TenderDal tenderDal = new TenderDal();
        public TenderController(ILogger<VehicleController> log)
        {
            _log = log;
        }
        [HttpGet]// admin için
        public async Task<List<GetTenderDTO>> GetAll() //https://localhost:7011/Vehicle/VehicleList
        {
            return tenderDal.GetAllTenderForAdminUI();
        }
        [HttpGet]
        public async Task<List<TenderListVM>> GetAllTenderEndUserUI()   
        {
            return tenderDal.GetAllTenderForEndUserUI();
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
        public async Task<IActionResult> Createe()
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
