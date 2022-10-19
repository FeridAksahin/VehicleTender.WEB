using VehicleTender.Web.AdminUI.Models.Commission;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class CommissionPageModel
    {
        public CommissionDTO AddCommission { get; set; }
        public List<CommissionDTO> CommissionList { get; set; }
        public UpdateCommission UpdateCommission { get; set; }
    }
}
