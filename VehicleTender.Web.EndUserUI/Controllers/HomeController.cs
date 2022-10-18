using FluentValidation;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VehicleTender.WEB.EndUser.Validation;
using VehicleTender.WEB.UserDTO.VM.Account;
using VehicleTender.WEB.UserDTO.VM.Contact;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactVM contactVM)
        {
            ContactValidation contactValidation = new ContactValidation();
            ValidationResult result = contactValidation.Validate(contactVM);
            if (result.IsValid)
            {
                return RedirectToAction("Index");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            LoginValidation loginValidation = new LoginValidation();
            ValidationResult result = loginValidation.Validate(loginVM);
            if (result.IsValid)
            {
                return RedirectToAction("Index");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterVM registerVM)
        {
            RegisterValidation registerValidation = new RegisterValidation();
            ValidationResult result = registerValidation.Validate(registerVM);
            if (result.IsValid)
            {
                return RedirectToAction("Login");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }

        public ActionResult Expertise()
        {
            return View();
        }


        [HttpGet]
        public ActionResult CorporateRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CorporateRegister(CorporateRegisterVM corporateRegisterVM)
        {
            CorporateRegisterValidation corporateRegisterValidation = new CorporateRegisterValidation();
            ValidationResult result = corporateRegisterValidation.Validate(corporateRegisterVM);
            if (result.IsValid)
            {
                return RedirectToAction("Login");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }


        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(ResetPasswordVM resetPasswordVM)
        {
            ResetPasswordValidation resetPasswordValidation = new ResetPasswordValidation();
            ValidationResult result = resetPasswordValidation.Validate(resetPasswordVM);
            if (result.IsValid)
            {
                return RedirectToAction("Login");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }


        [HandleError]
        public ActionResult ErrorPage404()
        {
            return View();
        }

        [HandleError]
        public ActionResult ErrorPage500()
        {
            return View();
        }
    }
}