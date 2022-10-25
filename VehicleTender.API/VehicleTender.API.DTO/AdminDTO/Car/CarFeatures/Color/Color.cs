using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Color
{
    public class Color
    {
        public int ColorId { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string ColorName { get; set; }
    }
}
