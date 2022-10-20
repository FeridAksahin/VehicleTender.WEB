using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTender.Web.AdminUI.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }
        public IActionResult AdminHome()
        {
            _logger.LogInformation("fasdfasd");
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorization()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorizationDelete(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorizationAdd()
        {
            return View();
        }
    }
}
