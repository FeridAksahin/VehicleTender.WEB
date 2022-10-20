using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class AdvertInformationDTO
    {
        [StringType(Max = 20, Min = 3)]
        public string AdvertHeader { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string AdvertDescription { get; set; }
    }
}
