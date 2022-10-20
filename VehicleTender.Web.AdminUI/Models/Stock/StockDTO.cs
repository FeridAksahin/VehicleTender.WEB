using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Stock
{
    public class StockDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string KM { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Year { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Plaka { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Color { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string GarageCount { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string SaleCount { get; set; }
    }
}
