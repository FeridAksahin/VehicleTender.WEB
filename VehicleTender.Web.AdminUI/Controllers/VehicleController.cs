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
        public IActionResult VehicleList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleFeatureList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StockList()
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
        public IActionResult VehicleDefineAndListing()
        {
            return View();
        }
    }
}
