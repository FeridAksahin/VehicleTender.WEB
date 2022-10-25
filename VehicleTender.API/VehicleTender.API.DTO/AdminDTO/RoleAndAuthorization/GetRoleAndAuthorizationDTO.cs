using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.RoleAndAuthorization
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
