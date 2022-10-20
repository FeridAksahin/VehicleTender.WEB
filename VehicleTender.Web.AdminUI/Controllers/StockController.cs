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
        public IActionResult Index()
        {
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
