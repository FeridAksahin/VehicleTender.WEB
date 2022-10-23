using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Commission
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
