using VehicleTender.Web.AdminUI.Models.Admin;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class AdminsPage
    {
        public AddAdminDTO addAdminDTO { get; set; }
        public List<GetAdminDTO> getAdminDTO { get; set; }  
        public UpdateAdmin updateAdmin { get; set; }  

    }
}
