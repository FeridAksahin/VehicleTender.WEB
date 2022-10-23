using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car
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
