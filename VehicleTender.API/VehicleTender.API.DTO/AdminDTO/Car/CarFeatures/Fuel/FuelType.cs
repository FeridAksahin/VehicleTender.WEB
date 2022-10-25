using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Fuel
{
    public class FuelType
    {
        public int Id { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string FuelTypeName { get; set; }
    }
}
