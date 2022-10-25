using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.RoleAndAuthorization
{
    public class RoleAuthorizationUpdateDTO
    {
        public int RoleName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string AuthorizationName { get; set; }
    }
}
