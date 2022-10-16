using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Expertise()
        {
            return View();
        }

        public ActionResult CorporateRegister()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
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