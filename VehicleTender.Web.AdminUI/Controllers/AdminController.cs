using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AdminController(ILogger<AdminController> logger,IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }
        public IActionResult AdminHome()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login","Auth");
            }
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorization()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorizationDelete(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        [HttpGet]
        public IActionResult RoleAndAuthorizationAdd()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}
