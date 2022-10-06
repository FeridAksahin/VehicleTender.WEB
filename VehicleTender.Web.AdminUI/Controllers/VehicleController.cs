using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class VehicleController : Controller
    {
        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndividualVehiclePurchaseListing()
        {
            return View();
        }
    }
}
