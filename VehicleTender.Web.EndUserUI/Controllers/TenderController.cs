using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Tender;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class TenderController : Controller
    {
        // GET: Tender
        TenderService tenderService = new TenderService();
        Token token = new Token();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateTender()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> ListTender()
        {
            PageModelTender pageModel = new PageModelTender();
            token.AccessToken = HttpContext.Request.Cookies["token"].Value;
            pageModel.TenderList = await tenderService.GetTenderList(token); ;
            return View(pageModel);
        }
        [HttpGet]
        public ActionResult TenderDetail(int id)
        {
          
            List<TenderCar> tenderCarList = new List<TenderCar>() {
            new TenderCar
                {
                    Brand="Ford",
                    CarId=id,
                    CreatedBy="vs",
                    CreatedDate="22.10.2022",
                    IndividualOrCorparate="Kurumsal",
                    Model="Focus",
                    Price="340.000",
                    Statu="Giriş"
                },
            new TenderCar
                {
                    Brand="Ferrari",
                    CarId=id,
                    CreatedBy="vs",
                    CreatedDate="22.10.2022",
                    IndividualOrCorparate="Kurumsal",
                    Model="Focus",
                    Price="3.000",
                    Statu="Giriş"
                }
            };
            token.AccessToken = HttpContext.Request.Cookies["token"].Value;
            tenderService.GetTenderCar(token,id);
            return View(tenderCarList);
        }
        [HttpGet]
        public ActionResult TenderCarDetail(int id)
        {
            TenderCarDetail tenderCarDetail = new TenderCarDetail()
            {
                Color = "Sarı",
                CarId = id,
                KM="345.000",
                Brand="Ferrari",
                Email="vsvs.@gmail.com",
                FuelType="Benzinli",
                Hardware="NoS",
                Model="Focus",
                Name="vsvs",
                Telephone="0246246",
                TransmissionType="Düz",
                Version="V2.5",
                Year="2017",
                AdvertDescription="Doktordan 2 yıl sürülmüş temizdir.",
                AdvertHead="Ferrari V2.5 Yeni",
                BodyType="Sedan",
                Price="3.545.000"

            };
            return View(tenderCarDetail);
        }
    }
}