using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware
{
    public class UpdateHardware
    {
        public int Id { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string HardwareName { get; set; }
    }
}
