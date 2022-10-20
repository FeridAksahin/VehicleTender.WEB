using VehicleTender.Web.AdminUI.Models.Stock;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class StockPage
    {
        public List<StockCompanyNameDTO> GetAllCompanyName { get; set; }
        public List<StockDTO> GetStockDTO { get; set; }
    }
}
