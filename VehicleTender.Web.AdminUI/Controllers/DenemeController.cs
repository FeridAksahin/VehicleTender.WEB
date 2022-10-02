using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class DenemeController : Controller
    {

        public IActionResult AdminHome()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
