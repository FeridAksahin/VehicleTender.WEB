using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Stock;
using VehicleTender.Web.AdminUI.Models.Tender;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class TenderController : Controller
    {
        TenderService tenderService = new TenderService();
        [HttpGet]
        public IActionResult Tender()
        {
            TenderDTO tenderDTO = new TenderDTO();
            List<GetTenderDTO> testlikTenderList = new List<GetTenderDTO>();
            GetTenderDTO tender = new GetTenderDTO();
            tender.TenderStart = DateTime.Now;
            tender.Statu = "Başladı";
            tender.TenderId = 1;
            tender.IndivudualOrCorparate = "Bireysel";
            tender.TenderStart = DateTime.Now;
            tender.CreatedBy = 1;
            tender.CreatedDate = DateTime.Now;
            tender.TenderName = "İhale";
            testlikTenderList.Add(tender);
            tenderDTO.TenderList = testlikTenderList;

            return View(tenderDTO);
        }

        [HttpPost]
        public IActionResult Tender(string? tenderName, string? isIndividual, string? statu)
        {
            TenderDTO tenderDTO = new TenderDTO();
            if (tenderName != null || isIndividual != null || statu != null)
            {
                List<GetTenderDTO> testlikTenderList = new List<GetTenderDTO>();
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
                tenderDTO.TenderList = testlikTenderList;
            }
            return View(tenderDTO);
        }
        public IActionResult NewTenderCreate()
        {
            return View();
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
                TenderStartCarPrice = 150
            });

            return View(updateTender);
        }

        [HttpPost]
        public IActionResult UpdateTender(int id)
        {
            UpdateTenderDTO updateTender = new UpdateTenderDTO();
            updateTender.CompanyName = "A";
            updateTender.TenderName = "İhaleAdi";
            updateTender.IndividualOrCorparate = "Bireysel";
            updateTender.Statu = "Başladı";
            updateTender.TenderStartDate = DateTime.Now;
            updateTender.TenderStartHour = DateTime.Now;
            updateTender.TenderEndTime = DateTime.Now;
            updateTender.TenderEndHour = DateTime.Now;
            return View(updateTender);
        }




    }
}
