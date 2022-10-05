using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class TenderController : Controller
    {
        public IActionResult TenderList()
        {
            return View();
        }
    }
}
