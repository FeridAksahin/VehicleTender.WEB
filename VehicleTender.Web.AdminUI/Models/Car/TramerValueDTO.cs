using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class TramerValueDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string Orginal { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Painted { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Changed { get; set; }
    }
}
