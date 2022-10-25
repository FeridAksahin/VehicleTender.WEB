using VehicleTender.API.DTO.AdminDTO.Models.Admin;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class AdminsPage
    {
        public AddAdminDTO addAdminDTO { get; set; }
        public List<GetAdminDTO> getAdminDTO { get; set; }
    }
}
