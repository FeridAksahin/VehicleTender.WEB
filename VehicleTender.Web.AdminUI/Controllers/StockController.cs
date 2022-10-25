using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Stock;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class StockController : Controller
    {
        Token token = new Token();
        StockService stockService = new StockService();
       
        IHttpContextAccessor _httpContextAccessor;
        public StockController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            StockPage companyName = new StockPage();
            List<StockCompanyNameDTO> testlikCompanyNameList = new List<StockCompanyNameDTO>();
            companyName.GetAllCompanyName = new List<StockCompanyNameDTO>();
            testlikCompanyNameList.Add(new StockCompanyNameDTO()
            {
                CompanyId = 1,
                CompanyName = "BilgeAdam"
            });
            companyName.GetAllCompanyName = testlikCompanyNameList;

         //   await stockService.GetAllStock(token);
            return View(companyName);
        }

        [HttpGet]
        public IActionResult Detail(int companyId)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            StockPage stock = new StockPage();
            List<StockDTO> testlikStockList = new List<StockDTO>();
            StockDTO testlik = new StockDTO();
            testlik.CarBrand = "BMW";
            testlik.CarModel = "320";
            testlik.Year = "2015";
            testlik.KM = "17520";
            testlik.Plaka = "1A1";
            testlik.Color = "Siyah";
            testlik.GarageCount = "2";
            testlik.SaleCount = "5";
            testlikStockList.Add(testlik);
            stock.GetStockDTO = testlikStockList;
           // await stockService.GetStockById(token, companyName);
            
            return View(stock);
        }


    }
}
