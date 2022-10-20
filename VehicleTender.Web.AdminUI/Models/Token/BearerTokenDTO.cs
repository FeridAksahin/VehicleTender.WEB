using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Token
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
