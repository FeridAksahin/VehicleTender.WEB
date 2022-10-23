using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Token
{
    public class UserLoginDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string Password { get; set; }
        [EmailType(EmailValidateType = EmailValidateType.General)]
        public string Mail { get; set; }
    }
}
