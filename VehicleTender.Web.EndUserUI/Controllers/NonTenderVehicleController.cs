using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleTender.WEB.UserDTO.VM.Advert;
using VehicleTender.WEB.UserDTO.VM.Page;

namespace VehicleTender.Web.EndUserUI.Controllers
{ //hemen araç al (bireysel araç satıştan gelen araçlara alım-satım controllerı)
    public class NonTenderVehicleController : Controller
    {
        // GET: NonTenderVehicle
        [HttpGet]
        public ActionResult BuyAVehicleNow()
        {
            BuyAVehicleNowVM advertPage = new BuyAVehicleNowVM();
            List<CarListVM> carList = new List<CarListVM>();
            CarListVM car = new CarListVM()
            {
                CarId = 1,
                BrandName = "Mercedes",
                ModelName = "CLA",
                Kilometer = "2500",
                GearTypeName = "Otomatik",
                ColorName = "Siyah",
                FuelTypeName = "Benzinli",
                HardwareId = "Turbo",
                Version = "Yeni",
                BodyTypeName = "Sedan",   
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
                CarId = 1,
                BrandName = "Mercedes",
                ModelName = "CLA",
                Kilometer = "2500",
                GearTypeName = "Otomatik",
                ColorName = "Siyah",
                FuelTypeName = "Benzinli",
                HardwareId = "Turbo",
                Version = "Yeni",
                BodyTypeName = "Sedan",
                Year = 2015,
                Description = "Acil satılık, az kullanılmış aynı zamanda krediye de uygundur."
            };
            carList.Add(car);
            return View(carList);
        }

    }
}