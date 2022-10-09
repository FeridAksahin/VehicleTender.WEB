using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorization()
        {
            return View();
        }
    }
}
