using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand
{
    public class Brand
    {
        public int? Id { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string BrandName { get; set; }
    }
}
