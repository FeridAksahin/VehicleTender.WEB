using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.CorporateUser;
using VehicleTender.Web.AdminUI.Models.IndividualCar;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class UserController : Controller
    {
        CorporateUserService corporateUservice = new CorporateUserService();
        BearerTokenDTO token = new BearerTokenDTO(); //durumluk 
        IndividualCarService individualCarService = new IndividualCarService();
        IHttpContextAccessor _httpContextAccessor;
        public UserController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public async Task<IActionResult> CorporateUsers(string? companyType, string? packetType) //filtrelemeyi query string ile aldgımız için
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            List<GetCorporateUserDTO> listCorporateUser = new List<GetCorporateUserDTO>();
            if (companyType != null)
            {
                //listCorporateUser = await corporateUservice.CorporateUserListBySearchFiltering(token,packetType); //paket tipi için
                GetCorporateUserDTO testlik = new GetCorporateUserDTO();  
                testlik.isActive = true;
                testlik.Telephone = "test";
                testlik.Mail = "testttttttt";
                testlik.Surname = "vs";
                testlik.Username = "3r";
                testlik.UserId = 5;
                testlik.Name = "2";
                testlik.CompanyName = "ag3r";
                testlik.Address = "argaerg";
                testlik.CompanyType = "vs";
                testlik.District = "22";
                listCorporateUser.Add(testlik);
            }
            else
            {
                //listCorporateUser = await corporateUservice.GetAllCorporateUser(token); // -- db den çekilmediginde null hatası veriyor 

                GetCorporateUserDTO testlik = new GetCorporateUserDTO(); //o yüzden testlik 
                testlik.isActive = true;
                testlik.Telephone = "gearg";
                testlik.Mail = "asdf";
                testlik.Surname = "vs";
                testlik.Username = "agaraerg";
                testlik.UserId = 4;
                testlik.Name = "gagarge";
                testlik.CompanyName = "agr";
                testlik.Address = "argaerg";
                testlik.CompanyType = "Kurumsal";
                testlik.District = "gaerg";
                listCorporateUser.Add(testlik);
            }
          
            return View(listCorporateUser);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCorporateUser(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            // var d = updateIsActive.isActive;
            UpdateUser updateUser = new UpdateUser();
            updateUser.isActive = false;
            updateUser.PacketId = 2;
            updateUser.UserId = id;
            return View(updateUser);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCorporateUser(UpdateUser updateUser)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            //var d = updateIsActive.PacketId;
            return RedirectToAction("CorporateUsers");
        }
        public IActionResult Profile()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> IndividualVehicleSalesList(string? brand, string? model, string? statu)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            IndividualVehiclePage individualVehiclePage = new IndividualVehiclePage();
            List<GetIndividualCarSaleDTO> getIndividualCarSaleList = new List<GetIndividualCarSaleDTO>();
           
            if (statu != null)
            {
                GetIndividualCarSaleDTO testlik2 = new GetIndividualCarSaleDTO();
                //getIndividualCarSaleList = await individualCarService.GetAllIndividualCarBySearchFiltering(token,statu); 
                testlik2.Statu = "Giriş";
                testlik2.CarId = "2";
                testlik2.CarBrand = "vs";
                testlik2.CarModel = "araaergg";
                testlik2.CreatedBy = "aerghaeh";
                getIndividualCarSaleList.Add(testlik2);
                individualVehiclePage.GetIndividualCarSaleList = getIndividualCarSaleList;
            }
            else
            {
                GetIndividualCarSaleDTO testlik = new GetIndividualCarSaleDTO();
                //getIndividualCarSaleList= await individualCarService.GetAllIndividualCar(token);  
                testlik.Statu = "Satıldı";
                testlik.CarId = "2";
                testlik.CarBrand = "vs";
                testlik.CarModel = "agaraerg";
                testlik.CreatedBy = "aerghaeh";
                getIndividualCarSaleList.Add(testlik);
                individualVehiclePage.GetIndividualCarSaleList = getIndividualCarSaleList;
            }
 
          
  
            return View(individualVehiclePage);
        }

        [HttpGet]
        public async Task<IActionResult> IndividualVehicleSalesDetail(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            IndividualCarSaleUpdateDetailPageDTO individualCarSaleUpdateDetailPageDTO = new IndividualCarSaleUpdateDetailPageDTO();
            //individualCarSaleUpdateDetailPageDTO= await individualCarService.GetIndividualCarDetailForIntoUpdateButton(token, id.ToString());
            individualCarSaleUpdateDetailPageDTO.KM = "egrerg";
            individualCarSaleUpdateDetailPageDTO.Version = "gafg";
            individualCarSaleUpdateDetailPageDTO.MemberNameSurname = "farg";
            individualCarSaleUpdateDetailPageDTO.Year = "2005";
            individualCarSaleUpdateDetailPageDTO.BodyType = "Sedan";
            individualCarSaleUpdateDetailPageDTO.CarBrand = "gaerg";
            individualCarSaleUpdateDetailPageDTO.Description = "ahaeth";
            individualCarSaleUpdateDetailPageDTO.Statu = "arg";
            individualCarSaleUpdateDetailPageDTO.PreAssesmentPrice = "4353";
            individualCarSaleUpdateDetailPageDTO.CarId = id;
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
            individualCarSaleUpdateDetailPageDTO.Tramer = tramerDTO;
            individualCarSaleUpdateDetailPageDTO.TotalSumTramer = 234;
            return View(individualCarSaleUpdateDetailPageDTO);
        }
        [HttpPost]
        public async Task<IActionResult> IndividualVehicleSalesDetail(IndividualCarSaleUpdateDetailPageDTO updateCar)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            //await individualCarService.UpdateIndividualCar(token, updateCar);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteIndividualVehicleSales(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await individualCarService.DeleteIndividualCar(token, id);
            return RedirectToAction("IndividualVehicleSalesList");
        }
    }
}