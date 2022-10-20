using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.Models.Notary;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class NotaryController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
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
           
          
            notaryDTO.NotaryPrice = notaryDTO.NotaryPrice;
            notaryDTO.EndDate = notaryDTO.EndDate;
               
            return RedirectToAction("Index","Notary");
        }

      
        
       
       
    }
}
