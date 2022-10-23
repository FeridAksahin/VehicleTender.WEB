using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.WEB.UserDTO.VM.Advert;
using VehicleTender.WEB.UserDTO.VM.Page;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class AdvertListController : Controller
    {
        // GET: AdvertList
        public ActionResult Index()
        {
            return View();
        }
    }

}