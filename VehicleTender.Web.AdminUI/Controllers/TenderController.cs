using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class TenderController : Controller
    {
        public IActionResult TenderList()
        {
            return View();
        }

        public IActionResult TenderList2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tender()
        {
            return View();
        }
        public IActionResult NewTenderCreate()
        {
            return View();
        }

    }
}
