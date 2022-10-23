using VehicleTender.API.Validation.Attributes;

namespace VehicleTender.API.DTO.AdminDTO.Models.Car
{
    public class CarStatuHistoryDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
