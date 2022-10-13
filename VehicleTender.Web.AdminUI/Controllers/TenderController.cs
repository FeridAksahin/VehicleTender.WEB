using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class TenderController : Controller
    {

        [HttpGet]
        public IActionResult Tender()
        {
            return View();
        }
        public IActionResult NewTenderCreate()
        {
            return View();
        }
        public IActionResult UpdateTender()
        {
            return View();
        }


    }
}
