using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VehicleTender.Web.AdminUI.Models;
using VehicleTender.Web.AdminUI.Models.Auth;
using VehicleTender.Web.AdminUI.Models.Token;
using static System.Net.WebRequestMethods;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        IHttpContextAccessor _httpContextAccessor;
        public AuthController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {

                _httpContextAccessor.HttpContext.Response.Cookies.Append("deger", "ihsan",new CookieOptions()
                    { 
                    Expires = DateTime.Now.AddDays(1),
                    });

                return RedirectToAction("AdminHome", "Admin");
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult LogOut()
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete("deger");
            return RedirectToAction("Login");
        }
    }
}
