using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Validation;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Admin;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class UserOperationsController : Controller
    {
        AdminService adminService = new AdminService();
        BearerTokenDTO token = new BearerTokenDTO(); //durumluk 
        IHttpContextAccessor _httpContextAccessor;
        public UserOperationsController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            AdminsPage adminsPageModel = new AdminsPage();
            //adminsPageModel.getAdminDTO = await adminService.GetAllAdmin(token);  -- db den çekilmediginde null hatası veriyor 
            List<GetAdminDTO> listAdmin = new List<GetAdminDTO>();
            GetAdminDTO testlik = new GetAdminDTO(); //o yüzden testlik 
            testlik.isActive = true;
            testlik.Telephone = "gearg";
            testlik.Email = "asdf";
            testlik.Surname = "vs";
            testlik.Username = "agaraerg";
            testlik.UserId = 4;
            testlik.Name = "gagarge";
            listAdmin.Add(testlik);
            adminsPageModel.getAdminDTO = listAdmin;
            return View(adminsPageModel);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {
            UpdateAdmin updateAdmin = new UpdateAdmin();
            updateAdmin.isActive = false;
            updateAdmin.Telephone = "345345";
            updateAdmin.Email = "athatrh@gmail.com";
            updateAdmin.Username = "atharth";
            updateAdmin.Surname = "atharth";
            updateAdmin.UserId = id;
            updateAdmin.Password = "garehg";
            updateAdmin.Name = "gaerhae";

            return View(updateAdmin);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateAdmin updateAdmin)
        {
            if (ValidatorProperties.GetValidatorResult<UpdateAdmin>(updateAdmin).Count != 0)
                Console.WriteLine("aethaeth");

            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            var a = 4;
            Console.WriteLine(admin.getAdminDTO);
            adminService.AddNewAdmin(token, admin.addAdminDTO);
            return RedirectToAction("UserList");
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAdmin(AdminsPage admin)
        {
            if (ValidatorProperties.GetValidatorResult<AddAdminDTO>(admin.addAdminDTO.Username).Count != 0)
                await adminService.AddNewAdmin(admin.addAdminDTO);
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            var a = 4;
            Console.WriteLine(id);
            adminService.DeleteAdmin(token, id);
            return RedirectToAction("UserList");
        }

        [HttpPost]
        public IActionResult DeleteAdmin(int id)
        {
            var a = 4;
            Console.WriteLine(id);
            adminService.DeleteAdmin(token, id);
            return RedirectToAction("UserList");
        }
    }
}
