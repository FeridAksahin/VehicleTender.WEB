using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Stock
{
    public class StockCompanyNameDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
    }
}
