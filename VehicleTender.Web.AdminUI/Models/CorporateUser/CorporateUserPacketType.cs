using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.CorporateUser
{
    public class CorporateUserPacketType
    {
        public int UserId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string newPacketType { get; set; }
    }
}
