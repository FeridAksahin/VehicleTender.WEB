using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Commission
{
    public class UpdateCommission
    {
        public int CommissionId { get; set; }
        public double CommissionPrice { get; set; }
        public DateTime EndDate { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarStartingPrice { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarEndingPrice { get; set; }
    }
}
