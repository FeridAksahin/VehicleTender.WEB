using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Brand
{
    public class UpdateBrand
    {
        public int Id { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string BrandName { get; set; }
    }
}
