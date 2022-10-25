using VehicleTender.API.DTO.AdminDTO.Models.Stock;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class StockPage
    {
        public List<StockCompanyNameDTO> GetAllCompanyName { get; set; }
        public List<StockDTO> GetStockDTO { get; set; }
    }
}
