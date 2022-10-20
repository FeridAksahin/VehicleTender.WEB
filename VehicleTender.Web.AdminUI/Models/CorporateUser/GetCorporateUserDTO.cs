using VehicleTender.API.Validation.Attributes;
using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.CorporateUser
{
    public class GetCorporateUserDTO
    {
        public int UserId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Username { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Name { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Surname { get; set; }
        [EmailType(EmailValidateType =EmailValidateType.General)]
        public string Mail { get; set; }
        [StringType(Max = 20, Min = 9)]
        public string Telephone { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CompanyName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CompanyType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Address { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Province { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string District { get; set; }
        public bool isActive { get; set; }
    }
}
