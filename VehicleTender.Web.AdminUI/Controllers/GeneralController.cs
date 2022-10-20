using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestoreDeletedData()
        {
            return View();
        }

        public IActionResult Expertise()
        {
            return View();
        }
    }
}
