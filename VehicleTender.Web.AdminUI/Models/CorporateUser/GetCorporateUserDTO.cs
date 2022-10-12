namespace VehicleTender.Web.AdminUI.Models.CorporateUser
{
    public class GetCorporateUserDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public bool isActive { get; set; }
    }
}
