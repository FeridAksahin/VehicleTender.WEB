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
            IndividualVehicleSaleVM v = new IndividualVehicleSaleVM();
            v.BrandId = 2;
            
            Token token = new Token()
            {
                AccessToken = HttpContext.Request.Cookies["token"].Value
            };
            var s = token.AccessToken;
            var c  = await cs.CarList(token);
            BuyAVehicleNowVM advertPage = new BuyAVehicleNowVM();
            List<CarListVM> carList = new List<CarListVM>();
            CarListVM car = new CarListVM()
            {
                Id = 1,
                Brand = "Mercedes",
                Model = "CLA",
                KM = "2500",
                GearType = "Otomatik",
                Color = "Siyah",
                FuelType = "Benzinli",
                HardwareId = "Turbo",
                Version = "Yeni",
                BodyType = "Sedan",   
                Year = 2015,
                Description = "Acil satılık, az kullanılmış aynı zamanda krediye de uygundur."
            };

            carList.Add(car);
            advertPage.Cars = carList;

            return View(advertPage);
        }

        [HttpPost]
        public ActionResult BuyAVehicleNow(BuyAVehicleNowVM advertPage)
        {
            return View();
        }

        [HttpGet]
        public ActionResult VehicleDetail(int id)
        {
            List<CarListVM> carList = new List<CarListVM>();
            CarListVM car = new CarListVM()
            {
                Id = 1,
                Brand = "Mercedes",
                Model = "CLA",
                KM = "2500",
                GearType = "Otomatik",
                Color = "Siyah",
                FuelType = "Benzinli",
                HardwareId = "Turbo",
                Version = "Yeni",
                BodyType = "Sedan",
                Year = 2015,
                Description = "Acil satılık, az kullanılmış aynı zamanda krediye de uygundur."
            };
            carList.Add(car);
            return View(carList);
        }

    }
}