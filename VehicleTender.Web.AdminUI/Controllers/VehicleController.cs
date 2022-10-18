using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{

    public class VehicleController : Controller
    {
        BearerTokenDTO token = new BearerTokenDTO();
        CarService carService = new CarService();
        [HttpGet]
        public async Task<IActionResult> VehicleList(string? brandName, string? modelName, string? individualOrCorparate, string? statu)
        {
            AllCarPage allCarPageModel = new AllCarPage();
            if (brandName != null || modelName != null || individualOrCorparate != null || statu != null)
            {
               // allCarPageModel.GetAllCar = await carService.GetCarsBySearchFilter(token, individualOrCorparate); //filtreler birleştirip atancak tek string olarak
                List<GetCarDTO> testlikCarList = new List<GetCarDTO>();
                GetCarDTO testlik = new GetCarDTO();
                testlik.Statu = "vsvs";
                testlik.IndividualOrCorparate = "bireysel";
                testlik.CreatedDate = DateTime.Now;
                testlik.CreatedBy = "vsvs";
                testlik.CarBrand = "gagerg";
                testlik.CarModel = "garg";
                testlik.CarId = 2;
                testlikCarList.Add(testlik);
                allCarPageModel.GetAllCar = testlikCarList;
            }
            else
            {
               // allCarPageModel.GetAllCar = await carService.GetAllCar(token); // -- db den çekilmediginde null hatası veriyor 
                List<GetCarDTO> testlikCarList = new List<GetCarDTO>();
                GetCarDTO testlik = new GetCarDTO();
                testlik.Statu = "rgarh";
                testlik.IndividualOrCorparate = "kurumsal";
                testlik.CreatedDate = DateTime.Now;
                testlik.CreatedBy = "atrharth";
                testlik.CarBrand = "arharht";
                testlik.CarModel = "artharth";
                testlik.CarId = 2;
                testlikCarList.Add(testlik);
                allCarPageModel.GetAllCar = testlikCarList;
            }

            return View(allCarPageModel);
        }
        [HttpGet]
        public IActionResult VehicleBrandList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleModelList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleBodyTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleFuelTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleGearTypeList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleColorList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleHardwareList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StockList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndividualVehiclePurchaseListing()
        {
            return View();
        }
        public IActionResult VehicleDefineAndListing()
        {
            return View();
        }
        public IActionResult VehicleDetailInfo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddVehicle()
        {
            AddCarDTO addVehicleViewModel = new AddCarDTO();
            return View(addVehicleViewModel);
        }
        [HttpPost]
        public IActionResult AddVehicle(AddCarDTO addVehicleViewModel)
        {//tramer bilgilerini alma ve fotoğraf alma kısmı, hemen al satış butonu kısmı eksiktir 
            //carService.AddNewCar(token,addVehicleViewModel); //komisyon ve noter ücreti api tarafında belirlenecektir. bireysel ya da kurumsal olup olmadıgı api 
            //tarafında yazılan isme göre aratılıp db ye kaydedilcektir
            return View();
        }
        [HttpGet]
        public IActionResult UpdateVehicle()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult UpdateVehicle()
        {
            return View();
        }*/
    }
}
