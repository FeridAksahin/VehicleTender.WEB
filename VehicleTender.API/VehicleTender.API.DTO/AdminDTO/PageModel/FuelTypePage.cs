using VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Fuel;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class FuelTypePage
    {
        public FuelType FuelType { get; set; }
        public List<FuelType> GetAllFuelTypes { get; set; }
    }
}
