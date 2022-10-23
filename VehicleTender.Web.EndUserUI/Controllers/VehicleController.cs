using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.Models;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Stock;


namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class VehicleController : Controller
    {
        StockPageModel model = new StockPageModel();
       // StockService stockService = new StockService();
        TokenDTO token = new TokenDTO();

        private readonly CarService _vehicleService;
        public VehicleController()
        {
            _vehicleService = new CarService();
        }

        // GET: Vehicle
        public ActionResult Index()
        {
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
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Stock(string companyName,string count)
        {
            //model.stockList = await stockService.StockList(token);
            model.filterStock = new FilterStockVM();

            if (companyName!=null || count!=null)
            {
                //model.stockList = await stockService.FilterStock(token, companyName + "," + count);
                List<StockListVM> stockListVMs = new List<StockListVM>();
                StockListVM stockListVM = new StockListVM()
                {
                    CompanyName = "true",
                    LastModifiedDate = DateTime.Now,
                    StockNo = 1,
                    VehicleCount = "215",
                };
                stockListVMs.Add(stockListVM);
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
                model.stockList = stockListVMs;
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult GetVehicleInStock(int? id)
        {
            //model.vehicleInStock = await stockService.VehicleInStock(token, id);

            model.vehicleInStock = new List<VehicleInStockVM>();
            VehicleInStockVM vehicleInStockVM = new VehicleInStockVM()
            {
                Brand = "asdasd",
                CreatedDate = DateTime.Now,
                Model = "asdasd",
                PreAssessmentPrice = "asdasdas",
                Statu = "asdas"
            };
            model.vehicleInStock.Add(vehicleInStockVM);
            return View(model);
        }

    }
}