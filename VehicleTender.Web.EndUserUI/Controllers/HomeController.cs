using FluentValidation;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.WEB.EndUser.Validation;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Account;
using VehicleTender.WEB.UserDTO.VM.Contact;
using VehicleTender.WEB.UserDTO.VM.HomeModel;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            //Dikkat admin tarafından kaydedilen araçların resimleri hem enduserdan hem admin uı dan görüntülenmek üzere erişilmeli 
        
           List<HomeAdvertViewModel> list = new List<HomeAdvertViewModel>();
            HomeAdvertViewModel viewModel1 = new HomeAdvertViewModel();
            HomeAdvertViewModel viewModel2 = new HomeAdvertViewModel();
            HomeAdvertViewModel viewModel3 = new HomeAdvertViewModel();
            HomeAdvertViewModel viewModel4 = new HomeAdvertViewModel();
            viewModel1.AdvertHeader = "Doktordan Temiz Tempra Slx";
            viewModel1.KM = "1000";
            viewModel1.TransmissionType = "Düz";
            viewModel1.Photograph = "1.jpg";
            viewModel1.Model = "2000";

            viewModel2.AdvertHeader = "Öğretmenden Çiziksiz Bakımlı Tofaş";
            viewModel2.KM = "1324240";
            viewModel2.TransmissionType = "Otamatik";
            viewModel2.Photograph = @"2.jpg";
            viewModel2.Model = "2020";

            viewModel3.AdvertHeader = "Değişen Tek Şey Sağ Koltuktaki Manitalar";
            viewModel3.KM = "231230";
            viewModel3.TransmissionType = "Düz";
            viewModel3.Photograph = @"3.jpg";
            viewModel3.Model = "1990";

            viewModel4.AdvertHeader = "Dikiz Aynasından Hondaları görmek büyük zevk";
            viewModel4.KM = "23424";
            viewModel4.TransmissionType = "Düz";
            viewModel4.Photograph = @"4.jpg";
            viewModel4.Model = "1889";


            list.Add(viewModel1);
            list.Add(viewModel2);
            list.Add(viewModel4);
            list.Add(viewModel3);



            return View(list);
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
            if (HttpContext.Request.Cookies["token"] != null)
            {
                HttpCookie httpCookie = HttpContext.Request.Cookies["token"];
                string token = httpCookie.Values["value"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(TokenDTO tokenDTO,LoginVM loginVM)
        {
            AccountService accountService = new AccountService();
            LoginValidation loginValidation = new LoginValidation();
            ValidationResult result = loginValidation.Validate(loginVM);

            if (result.IsValid)
            {
                //var token=accountService.GetToken(tokenDTO, loginVM);

                HttpCookie httpCookie = new HttpCookie("token");
                httpCookie.Expires = DateTime.Now.AddDays(1);
                httpCookie.Values.Add("token","value");
                HttpContext.Response.Cookies.Add(httpCookie);

                return RedirectToAction(nameof(Login));
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