using VehicleTender.API.Validation.Attributes;
using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Admin
{
    public class GetAdminDTO
    {
        public int UserId { get; set; }
        [StringType(Max =20,Min =3)]
        public string Username { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string Name { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string Surname { get; set; }
        [StringType(Max = 20, Min = 9)]
        public string Telephone { get; set; }
        [EmailType(EmailValidateType =EmailValidateType.General)]
        public string Email { get; set; }
        public bool isActive { get; set; }
    }
}
