using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Stock
{
    public class StockCompanyNameDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
    }
}
