using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Fuel;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class FuelTypePage
    {
        public FuelType FuelType { get; set; }
        public List<FuelType> GetAllFuelTypes { get; set; }
    }
}
