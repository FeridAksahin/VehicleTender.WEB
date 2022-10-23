using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Hardware
{
    public class Hardware
    {
        public int? Id { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string HardwareName { get; set; }
    }
}
