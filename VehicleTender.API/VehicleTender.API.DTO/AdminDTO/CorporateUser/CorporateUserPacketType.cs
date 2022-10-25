using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.CorporateUser
{
    public class CorporateUserPacketType
    {
        public int UserId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string newPacketType { get; set; }
    }
}
