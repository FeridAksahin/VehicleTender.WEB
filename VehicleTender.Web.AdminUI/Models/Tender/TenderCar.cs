using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Tender
{
    public class TenderCar
    {
        public int CarId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TenderStartCarPrice { get; set; }
        public double TenderMinumumCarPrice { get; set; }
    }
}
