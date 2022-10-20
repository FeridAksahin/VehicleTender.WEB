using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class HardwareListPageModel
    {
        public List<Hardware> HardwareList { get; set; }
        public UpdateHardware UpdateHardware { get; set; }
        public Hardware Hardware { get; set; }
    }
}
