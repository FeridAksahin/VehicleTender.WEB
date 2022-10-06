namespace VehicleTender.Web.AdminUI.Models
{
    public class BearerTokenDTO
    {
        public string? TokenUri { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
