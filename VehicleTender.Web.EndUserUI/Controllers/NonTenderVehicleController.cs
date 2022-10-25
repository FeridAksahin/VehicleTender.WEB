using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Advert;
using VehicleTender.WEB.UserDTO.VM.Page;
using VehicleTender.WEB.UserDTO.VM.Vehicle;

namespace VehicleTender.Web.EndUserUI.Controllers
{ //hemen araç al (bireysel araç satıştan gelen araçlara alım-satım controllerı)
    public class NonTenderVehicleController : Controller
    {
        AdvertService cs = new AdvertService();
        // GET: NonTenderVehicle
        [HttpGet]
        public async Task<ActionResult> BuyAVehicleNow()
        {
            Token token = new Token()
            {
                AccessToken = HttpContext.Request.Cookies["token"].Value
            };
            var c  = await cs.CarList(token);

            BuyAVehicleNowVM advertPage = new BuyAVehicleNowVM();
            advertPage.Cars = c;

            return View(advertPage);
        }

        [HttpPost]
        public ActionResult BuyAVehicleNow(BuyAVehicleNowVM advertPage)
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> VehicleDetail(int id)
        {
            //Token token = new Token()
            //{
            //    //AccessToken = HttpContext.Request.Cookies["token"].Value
            //};
            Token token = new Token();
            CarListVM carDetail = await cs.GetById(token, id);
            return View(carDetail);
        }

    }
}