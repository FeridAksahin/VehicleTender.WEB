using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleTender.Web.EndUserUI.Controllers
{ //hemen araç al (bireysel araç satıştan gelen araçlara alım-satım controllerı)
    public class NonTenderVehicleController : Controller
    {
        // GET: NonTenderVehicle
        [HttpGet]
        public ActionResult BuyAVehicleNow()
        {
            return View();
        }
        [HttpGet]
        public ActionResult VehicleDetail()
        {
            return View();
        }

    }
}