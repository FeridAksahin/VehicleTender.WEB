namespace VehicleTender.Web.AdminUI.Models.Token
{
    public class BearerTokenDTO
    {
        public string? TokenUri { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
