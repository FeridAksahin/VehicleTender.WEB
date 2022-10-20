using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTender.Web.AdminUI.Models;
using VehicleTender.Web.AdminUI.Models.Login;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginModel user)
        {
            //if (true)
            //{
            //    CookieProccess cookie = new CookieProccess(HttpContext.);
            //    return RedirectToAction("Admin", "AdminHome");
            //}
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
