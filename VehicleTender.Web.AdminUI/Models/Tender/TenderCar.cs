namespace VehicleTender.Web.AdminUI.Models.Tender
{
    public class TenderCar
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Statu { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TenderStartCarPrice { get; set; }
        public double TenderMinumumCarPrice { get; set; }
    }
}
