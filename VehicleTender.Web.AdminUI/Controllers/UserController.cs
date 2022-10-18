using Microsoft.AspNetCore.Mvc;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.CorporateUser;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class UserController : Controller
    {
        CorporateUserService corporateUservice = new CorporateUserService();
        BearerTokenDTO token = new BearerTokenDTO(); //durumluk 
        [HttpGet]
        public async Task<IActionResult> CorporateUsers(string? companyType, string? packetType) //filtrelemeyi query string ile aldgımız için
        {
            CorporateUserPage corporateUserPageModel = new CorporateUserPage();
            if (companyType != null)
            {
                //corporateUserPageModel.getAllCorporateUser = await corporateUservice.CorporateUserListBySearchFiltering(token,packetType); //paket tipi için
                List<GetCorporateUserDTO> listCorporateUser = new List<GetCorporateUserDTO>();
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
                corporateUserPageModel.getAllCorporateUser = listCorporateUser;
            }
            else
            {
                // corporateUserPageModel.getAllCorporateUser = await corporateUservice.GetAllCorporateUser(token); // -- db den çekilmediginde null hatası veriyor 
                List<GetCorporateUserDTO> listCorporateUser = new List<GetCorporateUserDTO>();
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
                corporateUserPageModel.getAllCorporateUser = listCorporateUser;
            }
          
            return View(corporateUserPageModel);
        }

        public IActionResult Profile()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndividualVehicleSalesList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult IndividualVehicleSalesDetail()
        {
            return View();
        }
    }
}
