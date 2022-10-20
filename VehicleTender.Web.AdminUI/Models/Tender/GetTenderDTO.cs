using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Tender
{
    public class GetTenderDTO
    {
        /*
        public string TenderName { get; set; }
        public bool IndividualOrCorparate { get; set; }
        public string Statu{ get; set; }*/
        public int TenderId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string TenderName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string IndivudualOrCorparate { get; set; }
        public DateTime TenderStart { get; set; }
        public DateTime TenderEndTime { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
