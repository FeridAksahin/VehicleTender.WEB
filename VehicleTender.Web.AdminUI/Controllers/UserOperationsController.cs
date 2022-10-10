using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class UserOperationsController : Controller
    {
        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult PackageIdentification()
        {
            return View();
        }
    }
}
