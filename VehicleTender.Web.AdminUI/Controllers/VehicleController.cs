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
        public IActionResult VehicleBrandList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleModelList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleBodyTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleFuelTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleGearTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleColorList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleHardwareList()
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
        public IActionResult VehicleDetailInfo()
        {
            return View();
        }
    }
}
