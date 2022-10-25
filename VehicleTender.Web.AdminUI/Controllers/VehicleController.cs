using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Body;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Color;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Fuel;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Gear;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware;
using VehicleTender.Web.AdminUI.Models.Car.Model;
using VehicleTender.Web.AdminUI.Models.Commission;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class VehicleController : Controller
    {
        Token token = new Token();
        
        CarService carService = new CarService();
        
        IdentifyingCehicleFaturesService identifyingCehicleFaturesService = new();
        IHttpContextAccessor _httpContextAccessor;
        public VehicleController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> VehicleList(string? brandName, string? modelName, string? individualOrCorparate, string? statu)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
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
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
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
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.AddNewCarBrand(token, brandListPageModel.Brand.BrandName);
            return RedirectToAction(nameof(VehicleBrandList));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVehicleBrand(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.DeleteCarBrand(token,id);
            return RedirectToAction(nameof(VehicleBrandList));
        }

        [HttpGet]
        public IActionResult VehicleModelList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            List<CarModelDto> carModelDtos = new List<CarModelDto>()
            {
                new CarModelDto{Id=1, Name="Tofaş"},
                new CarModelDto{Id=2, Name="Fiat"},
                new CarModelDto{Id=3,Name="Renault"}
            };

            CarModelPagedDto carModelPagedDto = new CarModelPagedDto();
            carModelPagedDto.CarModelDtos = carModelDtos;


            
            return View(carModelPagedDto);
        }

        public IActionResult VehicleModelGetById(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return Json(new CarModelDto { Id = 1, Name = "Tofaş" });
        }

        [HttpGet]
        public IActionResult VehicleModelDelete(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return RedirectToAction("VehicleModelList", "VehicleController");
        }
        [HttpPost]
        public IActionResult VehicleModelUpdate(CarModelPagedDto carModelPagedDto)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            return RedirectToAction("VehicleModelList", "VehicleController");
        }
        public IActionResult VehicleModelAdd(CarModelPagedDto carModelPagedDto)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return RedirectToAction("VehicleModelList", "VehicleController");
        }

        [HttpGet]
        public async Task<IActionResult> VehicleBodyTypeList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            List<BodyType> bodyTypes = new List<BodyType>() {
                new BodyType() { Id=1,BodyTypeName="Sedan"},
                new BodyType() { Id=2,BodyTypeName="Copue"},
                new BodyType() { Id=3,BodyTypeName="Hatchback 3 Kapı"},
                new BodyType() { Id=4,BodyTypeName="Hatchback 5 Kapı"},
                new BodyType() { Id=5,BodyTypeName="Station Wagon"},
                new BodyType() { Id=6,BodyTypeName="MPV"},
                new BodyType() { Id=7,BodyTypeName="Roadster"},
                new BodyType() { Id=8,BodyTypeName="SUV"},
                new BodyType() { Id=9,BodyTypeName="Cabrio"},
            };
            //await identifyingCehicleFaturesService.GetAllBodyType(token);
            return View(bodyTypes);
        }
        [HttpPost]
        public async Task<IActionResult> VehicleAddBodyType(string bodyType)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.AddNewCarBodyType(token, bodyType);
            return RedirectToAction("VehicleBodyTypeList");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteBodyType(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.DeleteBodyType(token, id);
            return RedirectToAction("VehicleBodyTypeList");
        }
        [HttpGet]
        public IActionResult VehicleFuelTypeList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
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
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.AddNewFuelType(token, fuelType.FuelType.FuelTypeName);
            return RedirectToAction(nameof(VehicleFuelTypeList));
        }
        [HttpGet]
        public async Task<IActionResult> VehicleGearTypeList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            List<GearType> gearTypes = new List<GearType>()
            {
                new GearType(){Id=1,GearTypeName="Otomatik"}
            };
            //await identifyingCehicleFaturesService.GetAllGearType(token);
            return View(gearTypes);
        }
        [HttpPost]
        public async Task<IActionResult> VehicleAddGearType(string gearType)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.AddNewCarGearType(token, gearType);
            return RedirectToAction("VehicleGearTypeList");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteGearType(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.DeleteGearType(token, id);
            return RedirectToAction("VehicleGearTypeList");
        }
        [HttpGet]
        public IActionResult VehicleColorList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            ColorPageModel colorPage = new ColorPageModel();
            Color c = new Color();
            c.ColorId = 2;
            c.ColorName = "Yeşil";
            List<Color> test = new List<Color>();
            test.Add(c);
            colorPage.GetColorList = test;
            return View(colorPage);
        }
        [HttpPost]
        public async Task<IActionResult> VehicleColorList(ColorPageModel addColor) //add color
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            //await identifyingCehicleFaturesService.AddNewColor(token, addColor.Color.ColorName);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteColor(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            // await identifyingCehicleFaturesService.DeleteColor(token, id);
            return RedirectToAction("VehicleColorList");
        }
        [HttpGet]
        public async Task<IActionResult> VehicleHardwareList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
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
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.AddNewHardware(token, hardwareListPageModel.Hardware.HardwareName);
            return RedirectToAction(nameof(VehicleHardwareList));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVehicleHardware(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await identifyingCehicleFaturesService.DeleteHardware(token, id);
            return RedirectToAction(nameof(VehicleHardwareList));
        }
        [HttpGet]
        public IActionResult StockList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
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
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        public IActionResult VehicleDefineAndListing()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        public IActionResult VehicleDetailInfo()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddVehicle()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            AddCarDTO addVehicleViewModel = new AddCarDTO();
            return View(addVehicleViewModel);
        }
        [HttpPost]
        public  IActionResult AddVehicle(AddCarDTO addVehicleViewModel)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            //tramer bilgilerini alma ve fotoğraf alma kısmı, hemen al satış butonu kısmı eksiktir 
            //carService.AddNewCar(token,addVehicleViewModel); //komisyon ve noter ücreti api tarafında belirlenecektir. bireysel ya da kurumsal olup olmadıgı api 
            //tarafında yazılan isme göre aratılıp db ye kaydedilcektir

            carService.AddNewCar(token, addVehicleViewModel);

            List<string> images = new List<string>();//fotoğrafların yolları

            if (addVehicleViewModel.Picture != null)
            {
                for (int i = 0; i < addVehicleViewModel.Picture.Count(); i++)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(addVehicleViewModel.Picture[i].FileName);
                    var x = Directory.GetCurrentDirectory();
                    var path = Path.Combine(@"C:\Users\Doğukan Matuloğlu\source\repos\FeridAksahin\VehicleTender.WEB\carimages", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        //await addVehicleViewModel.Picture.CopyToAsync(stream);
                         addVehicleViewModel.Picture[i].CopyTo(stream);
                        
                        images.Add(fileName);
                    }
                }
               

            
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateVehicle(string id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            // carService.GetCarDetailForIntoUpdateButton(token, id);
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
            updateCarViewModel.BuyNowSell = true;
            updateCarViewModel.CarBrand = "gaerg";
            updateCarViewModel.Description = "ahaeth";
            updateCarViewModel.Statu = "arg";
            updateCarViewModel.PreAssesmentPrice = 232;
            updateCarViewModel.CarId = id;
            TramerDTO tramerDTO = new TramerDTO();
            tramerDTO.RightRearFender = "Orjinal";
            tramerDTO.ReadHood = "Değişmiş";
            tramerDTO.LeftRearFender = "Orjinal";
            tramerDTO.RightRearDoor = "Boyalı";
            tramerDTO.RightFrontDoor = "Değişmiş";
            tramerDTO.Ceiling = "Orjinal";
            tramerDTO.LeftRearDoor = "Orjinal";
            tramerDTO.LeftFrontDoor = "Boyalı";
            tramerDTO.RightFrontFender = "Değişmiş";
            tramerDTO.EngineBonnet = "Orjinal";
            tramerDTO.LeftFrontFender = "Orjinal";
            tramerDTO.FrontBumper = "Boyalı";
            tramerDTO.RearBumper = "Boyalı";
            updateCarViewModel.Tramer = tramerDTO;
            updateCarViewModel.TotalSumTramer = 21;

            //carService.GetCarDetailForIntoUpdateButton(token, id);
            return View(updateCarViewModel);
        }
        [HttpPost]
        public IActionResult UpdateVehicle(UpdateCarDTO updateCarViewModel)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

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
