using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class GeneralController : Controller
    { 
        IHttpContextAccessor _httpContextAccessor;
        public GeneralController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        public IActionResult RestoreDeletedData()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        public IActionResult Expertise()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}
