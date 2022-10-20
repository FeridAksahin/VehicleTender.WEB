using VehicleTender.Web.AdminUI.Models.CorporateUser;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class CorporateUserPage
    {
        public List<GetCorporateUserDTO> getAllCorporateUser { get; set; }
        public int PacketId  { get; set; }
        public bool isActive  { get; set; }
    }
}
