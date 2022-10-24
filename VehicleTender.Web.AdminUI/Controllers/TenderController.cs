using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Reflection;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Body;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Stock;
using VehicleTender.Web.AdminUI.Models.Tender;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class TenderController : Controller
    {
        BearerTokenDTO token = new BearerTokenDTO();
        TenderService tenderService = new TenderService();
        [HttpGet]
        public async Task<IActionResult> Tender()
        {
            return View(await tenderService.TenderList());
        }

        [HttpPost]
        public async Task<IActionResult> Tender(string? tenderName, string? isIndividual, string? statu)
        {
            List<GetTenderDTO> testlikTenderList = new List<GetTenderDTO>();
            if (tenderName != null || isIndividual != null || statu != null)
            {
                GetTenderDTO tender = new GetTenderDTO();
                tender.TenderStart = DateTime.Now;
                tender.Statu = "Başladı";
                tender.TenderId = 1;
                tender.IndivudualOrCorparate = "Bireysel";
                tender.TenderStart = DateTime.Now;
                tender.CreatedBy = 1;
                tender.CreatedDate = DateTime.Now;
                tender.TenderName = "İhaleAdi";
                testlikTenderList.Add(tender);
            }
            return View(testlikTenderList);
        }
        [HttpGet]
        public IActionResult NewTenderCreate()
        {
            AddNewTenderDTO addNewTender = new AddNewTenderDTO();
            TenderCarPriceAndTenderCar tenderCarPriceAndTenderCar = new TenderCarPriceAndTenderCar();
            List<TenderCar> tenderCarList = new List<TenderCar>();
            tenderCarList.Add(new TenderCar()
            {
                CarId = 1,
                CarBrand = "Mercedes",
                CarModel = "CLA",
                CreatedBy = "Okan",
                CreatedDate = DateTime.Now,
                Statu = "Satışta",
                TenderStartCarPrice = 100,
                TenderMinumumCarPrice = 1500
            });
            tenderCarList.Add(new TenderCar()
            {
                CarId = 1,
                CarBrand = "Mercedes",
                CarModel = "CLA",
                CreatedBy = "Okan",
                CreatedDate = DateTime.Now,
                Statu = "Satışta",
                TenderStartCarPrice = 100,
                TenderMinumumCarPrice = 1500
            });
            //await tenderService.AddNewTender(token, addNewTender);
            addNewTender.GetAllCars = tenderCarList;
            return View(addNewTender);
        }

        [HttpPost]
        public async Task<IActionResult> NewTenderCreate(AddNewTenderDTO addNewTenderDTO)
        {
            await tenderService.AddNewTender(token, addNewTenderDTO);
            return RedirectToAction("Tender");
        }

        [HttpGet]
        public IActionResult UpdateTender()
        {

            UpdateTenderDTO updateTender = new UpdateTenderDTO();
            updateTender.CompanyName = "BilgeAdam";
            updateTender.TenderName = "Mercedes İhalesi";
            updateTender.IndividualOrCorparate = "Kurumsal";
            updateTender.Statu = "Başladı";
            updateTender.TenderStartDate = DateTime.Now;
            updateTender.TenderStartHour = DateTime.Now;
            updateTender.TenderEndTime = DateTime.Now;
            updateTender.TenderEndHour = DateTime.Now;
            updateTender.TenderCar = new List<TenderCar>();
            updateTender.TenderCar.Add(new TenderCar()
            {
                CarId = 1,
                CarBrand = "BMW",
                CarModel = "320",
                Statu = "Satışta",
                CreatedBy = "Okan",
                CreatedDate = DateTime.Now,
                TenderMinumumCarPrice = 100,
                TenderStartCarPrice = 150,
            });

            return View(updateTender);
        }

        [HttpPost]
        public IActionResult UpdateTender(int id)
        {

            UpdateTenderDTO updateTender = new UpdateTenderDTO();
            //await tenderService.UpdateTender(token, updateTender);
            updateTender.CompanyName = "A";
            updateTender.TenderName = "Yeniİhale";
            updateTender.IndividualOrCorparate = "Bireysel";
            updateTender.Statu = "Başladı";
            updateTender.TenderStartDate = DateTime.Now;
            updateTender.TenderStartHour = DateTime.Now;
            updateTender.TenderEndTime = DateTime.Now;
            updateTender.TenderEndHour = DateTime.Now;
            updateTender.TenderCar = new List<TenderCar>();
            updateTender.TenderCar.Add(new TenderCar()
            {
                CarId = 1,
                CarBrand = "BMW",
                CarModel = "320",
                Statu = "Satışta",
                CreatedBy = "Okan",
                CreatedDate = DateTime.Now,
                TenderMinumumCarPrice = 100,
                TenderStartCarPrice = 150,
            });
            return RedirectToAction("Tender");
        }

        public async Task<IActionResult> DeleteTender(int id)
        {
            await tenderService.DeleteTender(token, id);
            return RedirectToAction("Tender");
        }

    }
}
