using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.RoleAndAuthorization
{
    public class GetRoleAndAuthorizationDTO
    {
        public int RoleId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string RoleName { get; set; }
        public int AuthorizationId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Authorization { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
