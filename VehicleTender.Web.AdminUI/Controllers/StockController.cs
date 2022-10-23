using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Stock;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class StockController : Controller
    {
        IHttpContextAccessor _httpContextAccessor;
        public StockController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            StockPage companyName = new StockPage();
            List<StockCompanyNameDTO> testlikCompanyNameList = new List<StockCompanyNameDTO>();
            StockCompanyNameDTO testlik = new StockCompanyNameDTO();
            testlik.CompanyName = "BilgeAdam";
            testlik.CompanyId = 1;
            testlikCompanyNameList.Add(testlik);
            companyName.GetAllCompanyName = testlikCompanyNameList;
            return View(companyName);
        }

        [HttpGet]
        public IActionResult Detail(string companyName)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["deger"] == null)
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
            
            return View(stock);
        }


    }
}
