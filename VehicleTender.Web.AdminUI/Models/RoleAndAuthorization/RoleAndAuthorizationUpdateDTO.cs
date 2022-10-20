using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.RoleAndAuthorization
{
    public class RoleAuthorizationUpdateDTO
    {
        public int RoleName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string AuthorizationName { get; set; }
    }
}
