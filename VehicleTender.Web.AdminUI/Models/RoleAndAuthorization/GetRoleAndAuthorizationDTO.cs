namespace VehicleTender.Web.AdminUI.Models.RoleAndAuthorization
{
    public class GetRoleAndAuthorizationDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int AuthorizationId { get; set; }
        public string Authorization { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
