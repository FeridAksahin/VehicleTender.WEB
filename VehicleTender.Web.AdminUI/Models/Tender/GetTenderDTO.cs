namespace VehicleTender.Web.AdminUI.Models.Tender
{
    public class GetTenderDTO
    {
        /*
        public string TenderName { get; set; }
        public bool IndividualOrCorparate { get; set; }
        public string Statu{ get; set; }*/
        public int TenderId { get; set; }
        public string TenderName { get; set; }
        public string IndivudualOrCorparate { get; set; }
        public DateTime TenderStart { get; set; }
        public DateTime TenderEndTime { get; set; }
        public string Statu { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
