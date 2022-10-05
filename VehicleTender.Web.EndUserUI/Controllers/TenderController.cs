using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class TenderController : Controller
    {
        // GET: Tender
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateTender()
        {
            return View();
        }

        public ActionResult ListTender()
        {
            return View();
        }
    }
}