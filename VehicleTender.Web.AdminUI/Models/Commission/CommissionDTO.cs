namespace VehicleTender.Web.AdminUI.Models.Commission
{
    public class CommissionDTO
    {
        public int? ID { get; set; }
        public double CommissionPrice { get; set; }
        public DateTime EndDate { get; set; }
        public string CarStartingPrice { get; set; }
        public string CarEndingPrice { get; set; }
    }
}
