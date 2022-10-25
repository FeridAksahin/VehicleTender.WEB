using VehicleTender.API.Validation.Attributes;

namespace VehicleTender.API.DTO.AdminDTO.Models.Car
{
    public class AdvertInformationDTO
    {
        [StringType(Max = 20, Min = 3)]
        public string AdvertHeader { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string AdvertDescription { get; set; }
    }
}
