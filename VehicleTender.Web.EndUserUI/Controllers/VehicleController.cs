using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.Models;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Stock;
using VehicleTender.WEB.UserDTO.VM.Vehicle;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class VehicleController : Controller
    {

        StockPageModel model = new StockPageModel();
       // StockService stockService = new StockService();
        Token token = new Token();
        

        private readonly CarService _vehicleService;
        public VehicleController()
        {
            _vehicleService = new CarService();

        }

        // GET: Vehicle
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        //[HttpGet]
        //public async Task<ActionResult> ListVehicle()
        //{
        //    List<VehicleListViewModel> list = await _vehicleService.GetListAsync(null);
        //    VehicleViewModel vehicleViewModel = new VehicleViewModel
        //    {
        //        VehicleList = list
        //    };
        //    return View(vehicleViewModel);
        //}

        [HttpGet]
        public ActionResult AddVehicle()
        {
            if (HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        //[HttpPost]
        //public ActionResult AddVehicle()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult UpdateVehicle()
        {
            if (HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        //[HttpPost]
        //public ActionResult UpdateVehicle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<ActionResult> ListVehicle(GetVehicleListInput input)
        //{
        //    List<VehicleListViewModel> list = await _vehicleService.GetListAsync(input);
        //    VehicleViewModel vehicleViewModel = new VehicleViewModel
        //    {
        //        VehicleList = list
        //    };
        //    return View(vehicleViewModel);
        //}
        [HttpGet]
        public ActionResult PostingSalesAdvertisement()
        {
            //if (HttpContext.Request.Cookies["token"] == null)
            //{
            //    return RedirectToAction("Login", "Home");
            //}

            return View();
        }
        [HttpPost]
        public ActionResult PostingSalesAdvertisement(PostingSalesModel car)
        {
            
            if (ModelState.IsValid == true)
            {
                VehicleService vehicleService = new VehicleService();
                PostingSalesAdvertisementVM vm = new PostingSalesAdvertisementVM()
                {
                    ArkaKaput = car.ArkaKaput,
                    ArkaTampon = car.ArkaTampon,
                    BodyTypeName = car.BodyTypeName,
                    BrandName = car.BrandName,
                    ColorName = car.ColorName,
                    Description = car.Description,
                    FuelTypeName = car.FuelTypeName,
                    GearTypeName = car.GearTypeName,
                    HardwareName = car.HardwareName ,
                    KM = car.KM,
                    ModelName = car.ModelName,
                    MotorKaputu = car.MotorKaputu,
                    OnTampon = car.OnTampon,
                    SagArkaCamurluk= car.SagArkaCamurluk,
                    SagArkaKapı= car.SagArkaKapı,
                    SagOnCamurluk= car.SagOnCamurluk,
                    SagOnKapı = car.SagOnKapı,
                    SolArkaCamurluk = car.SolArkaCamurluk,
                    SolArkaKapı = car.SolArkaKapı,
                    SolOnCamurluk = car.SolOnCamurluk,
                    SolOnKapı = car.SolOnKapı,
                    Tavan = car.Tavan,
                    TramerTutarı = car.TramerTutarı,
                    VersionName = car.VersionName,
                    Year = car.Year
                };
                string[] images = new string[5];
                int i = 0;
                foreach (var item in car.Photos)
                {
                    var image = Path.GetFileName(item.FileName);
                    var path = Path.Combine(Server.MapPath("~/img/"), image);
                    item.SaveAs(path);

                    images[i]= "~/img"+item.FileName;
                    i++;
                }
                vm.ImagePath = images;
                Token token = new Token();
                token.AccessToken = HttpContext.Request.Cookies["token"].Value;
                vehicleService.IndividualVehicleSale(token, vm);
                return View();
            }
            return View();

        }

        [HttpGet]
        public async Task<ActionResult> Stock(string companyName,string count)
        {
            if (HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            //model.stockList = await stockService.StockList(token);
            model.filterStock = new FilterStockVM();

            if (companyName!=null || count!=null)
            {
                //model.stockList = await stockService.FilterStock(token, companyName + "," + count);
                model.vehicleInStock = new List<VehicleInStockVM>();
                List<StockListVM> stockListVMs = new List<StockListVM>();
                StockListVM stockListVM = new StockListVM()
                {
                    CompanyName = "true",
                    LastModifiedDate = DateTime.Now,
                    StockNo = 1,
                    VehicleCount = "215",
                    
                };
                stockListVMs.Add(stockListVM);
                model.stockList = new List<StockListVM>();
                model.stockList=stockListVMs;
            }
            else
            {
                model.vehicleInStock = new List<VehicleInStockVM>();
                List<StockListVM> stockListVMs = new List<StockListVM>();
                StockListVM stockListVM = new StockListVM()
                {
                    CompanyName = "false",
                    LastModifiedDate = DateTime.Now,
                    StockNo = 1,
                    VehicleCount = "215",
                };
                stockListVMs.Add(stockListVM);
                model.stockList = new List<StockListVM>();
                model.stockList = stockListVMs;
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult GetVehicleInStock(int? id)
        {
            if (HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            //model.vehicleInStock = await stockService.VehicleInStock(token, id);
            List<VehicleInStockVM> vehicleInStockVMs = new List<VehicleInStockVM>();
            VehicleInStockVM vehicleInStockVM = new VehicleInStockVM()
            {
                Brand = "asdasd",
                CreatedDate = DateTime.Now,
                Model = "asdasd",
                PreAssessmentPrice = "asdasdas",
                Statu = "asdas",
                Id=1
            };
            vehicleInStockVMs.Add(vehicleInStockVM);
            model.vehicleInStock = new List<VehicleInStockVM>();
            model.vehicleInStock = vehicleInStockVMs;
            return View(model);
        }

    }
}