using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Token
{
    public class BearerTokenDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string? TokenUri { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string? RefreshToken { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
