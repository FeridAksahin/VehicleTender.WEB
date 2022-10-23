using System.ComponentModel.DataAnnotations;
using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Admin
{
    public class AddAdminDTO
    {
        public string Username { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string Name { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string Surname { get; set; }
        [StringType(Max = 20, Min = 9)]
        public string Telephone { get; set; }
        [EmailType(EmailValidateType = EmailValidateType.General)]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}
