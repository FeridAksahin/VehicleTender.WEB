using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult VehicleList()
        {
            return View();
        }
        public IActionResult StockList()
        {
            return View();
        }
        public IActionResult VehicleFeatureList()
        {
            return View();
        }

    }
}
