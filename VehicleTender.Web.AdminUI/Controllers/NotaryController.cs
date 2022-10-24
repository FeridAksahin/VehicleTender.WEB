using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.Models.Notary;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class NotaryController : Controller
    {
        IHttpContextAccessor _httpContextAccessor;
        public NotaryController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            NotaryDTO notaryDTO = new NotaryDTO()
            {
                Id = 1,
                NotaryPrice = 440,
                EndDate = new DateTime(2022, 12, 01)

            };


            return View(notaryDTO);
        }
        [HttpPost]
        public IActionResult Update(NotaryDTO notaryDTO)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            notaryDTO.NotaryPrice = notaryDTO.NotaryPrice;
            notaryDTO.EndDate = notaryDTO.EndDate;
               
            return RedirectToAction("Index","Notary");
        }

      
        
       
       
    }
}
