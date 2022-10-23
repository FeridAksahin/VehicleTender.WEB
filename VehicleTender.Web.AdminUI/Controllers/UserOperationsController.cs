using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        public IActionResult AddNewAdmin(AdminsPage admin)
        {
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
        public IActionResult DeleteAdmin(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            var a = 4;
            Console.WriteLine(id);
            adminService.DeleteAdmin(token, id);
            return RedirectToAction("UserList");
        }
        /*
        [HttpPost]
        public IActionResult UpdateAdmin(int id)
        {
            var a = 4;
            Console.WriteLine(id);
            return RedirectToAction("UserList");
        }*/

        /*
        [HttpGet]
        public IActionResult PackageIdentification()
        {
            return View();
        }*/

    }
}
