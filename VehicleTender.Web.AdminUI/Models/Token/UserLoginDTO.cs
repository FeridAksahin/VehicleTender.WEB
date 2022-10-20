using VehicleTender.API.Validation.Attributes;
using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Token
{
    public class UserLoginDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string Password { get; set; }
        [EmailType(EmailValidateType =EmailValidateType.General)]
        public string Mail { get; set; }
    }
}
