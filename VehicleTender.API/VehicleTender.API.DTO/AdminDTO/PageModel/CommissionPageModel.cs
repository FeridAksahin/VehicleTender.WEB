using VehicleTender.API.DTO.AdminDTO.Models.Commission;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class CommissionPageModel
    {
        public CommissionDTO AddCommission { get; set; }
        public List<CommissionDTO> CommissionList { get; set; }
        public UpdateCommission UpdateCommission { get; set; }
    }
}
