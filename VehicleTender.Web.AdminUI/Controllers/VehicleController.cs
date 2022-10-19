using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Fuel;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware;
using VehicleTender.Web.AdminUI.Models.Commission;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{

    public class VehicleController : Controller
    {
        BearerTokenDTO token = new BearerTokenDTO();
        
        CarService carService = new CarService();
        IdentifyingCehicleFaturesService identifyingCehicleFaturesService = new();

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
        public async Task<IActionResult> VehicleBrandList()
        {
            BrandListPageModel model = new BrandListPageModel();
            model.BrandList = new List<Brand>();
            //model.BrandList = await identifyingCehicleFaturesService.GetAllCarBrand(token);
            Brand brand = new Brand()
            {
                Id=1,
                BrandName = "deneme"
            };
            model.BrandList.Add(brand);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddVehicleBrand(BrandListPageModel brandListPageModel)
        {
            await identifyingCehicleFaturesService.AddNewCarBrand(token, brandListPageModel.Brand.BrandName);
            return RedirectToAction(nameof(VehicleBrandList));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVehicleBrand(int id)
        {
            await identifyingCehicleFaturesService.DeleteCarBrand(token,id);
            return RedirectToAction(nameof(VehicleBrandList));
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
            FuelTypePage model = new FuelTypePage();
            model.GetAllFuelTypes = new List<FuelType>();
            //model.GetAllFuelTypes = await identifyingCehicleFaturesService.GetFuelType(token);
            FuelType fuelType = new FuelType()
            {
                Id = 1,
                FuelTypeName = "Benzinli"
            };
            model.GetAllFuelTypes.Add(fuelType);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> VehicleFuelTypeList(FuelTypePage fuelType)
        {
            await identifyingCehicleFaturesService.AddNewFuelType(token, fuelType.FuelType.FuelTypeName);
            return RedirectToAction(nameof(VehicleFuelTypeList));
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
        public async Task<IActionResult> VehicleHardwareList()
        {
            HardwareListPageModel model = new HardwareListPageModel();
            model.HardwareList = new List<Hardware>();
            //model.HardwareList = await identifyingCehicleFaturesService.GetAllHardware(token);
            Hardware hardware = new Hardware()
            {
                Id=1,
                HardwareName = "deneme"
            };
            model.HardwareList.Add(hardware);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddVehicleHardware(HardwareListPageModel hardwareListPageModel)
        {
            await identifyingCehicleFaturesService.AddNewHardware(token, hardwareListPageModel.Hardware.HardwareName);
            return RedirectToAction(nameof(VehicleHardwareList));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVehicleHardware(int id)
        {
            await identifyingCehicleFaturesService.DeleteHardware(token, id);
            return RedirectToAction(nameof(VehicleHardwareList));
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
        public IActionResult UpdateVehicle(string id)
        {
            UpdateCarDTO updateCarViewModel = new UpdateCarDTO();
            updateCarViewModel.KM = "egrerg";
            updateCarViewModel.Version = "gafg";
            updateCarViewModel.CompanyName = "farg";
            updateCarViewModel.IndividualOrCorparate = "Corparate";
            updateCarViewModel.Year = "2005";
            updateCarViewModel.Price = 342;
            updateCarViewModel.ComissionPrice = "argearg";
            updateCarViewModel.AdvertHeader = "argerg";
            updateCarViewModel.AdvertDescription = "argaeaergeargaergeagreargggggggggggggggggggggggggggggggggggggggggggg";
            updateCarViewModel.BodyType = "Sedan";
            updateCarViewModel.BuyNowSell = false;
            updateCarViewModel.CarBrand = "gaerg";
            updateCarViewModel.BuyerName = "aregaerg";
            updateCarViewModel.BuyerSurname = "artharth";
            updateCarViewModel.BuyerTelephone = "trhsrthrsth";
            updateCarViewModel.BuyerCompanyName = "athrtharth";
            updateCarViewModel.Description = "ahaeth";
            updateCarViewModel.Statu = "arg";
            updateCarViewModel.PreAssesmentPrice = 232;
            updateCarViewModel.CarId = id;

            //carService.GetCarDetailForIntoUpdateButton(token, id);
            return View(updateCarViewModel);
        }
        [HttpPost]
        public IActionResult UpdateVehicle(UpdateCarDTO updateCarViewModel)
        {

            carService.UpdateCar(token, updateCarViewModel);
            //carService.GetCarDetailForIntoUpdateButton(token, id);
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
