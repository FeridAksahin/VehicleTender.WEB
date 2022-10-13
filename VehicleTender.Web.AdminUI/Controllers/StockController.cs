using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
