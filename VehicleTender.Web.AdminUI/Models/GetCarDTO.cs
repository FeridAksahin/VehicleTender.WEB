namespace VehicleTender.Web.AdminUI.Models
{
    public class GetCarDTO
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string IndividualOrCorparate { get; set; }
        public string Statu { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
