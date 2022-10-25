using VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Hardware;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class HardwareListPageModel
    {
        public List<Hardware> HardwareList { get; set; }
        public UpdateHardware UpdateHardware { get; set; }
        public Hardware Hardware { get; set; }
    }
}
