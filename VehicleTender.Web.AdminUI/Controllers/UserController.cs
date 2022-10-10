using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndividualVehicleSalesList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndividualVehicleSalesDetail()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CorporateUsers()
        {
            return View();
        }
    }
}
