namespace VehicleTender.Web.AdminUI.Models.Tender
{
    public class UpdateTenderDTO
    {
        public string TenderName { get; set; }
        public string IndividualOrCorparate { get; set; }
        public string CompanyName { get; set; }
        public string Statu { get; set; }
        public DateTime TenderStartDate { get; set; }
        public DateTime TenderStartHour { get; set; }
        public DateTime TenderEndTime { get; set; }
        public DateTime TenderEndHour { get; set; }
        public List<TenderCarPriceAndTenderCar> VehiclesIdSelectedForInclusionInTheTender { get; set; }
        public List<TenderCar> TenderCar { get; set; }
    }
}
