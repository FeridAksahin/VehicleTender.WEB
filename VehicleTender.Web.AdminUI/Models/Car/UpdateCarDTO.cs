using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class UpdateCarDTO
    {
        [StringType(Max = 20, Min = 0)]
        public string CarId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string IndividualOrCorparate { get; set; }
        public double Price { get; set; }
        public double PreAssesmentPrice { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CompanyName { get; set; } //bireysel ise onun ismi kurumsalsa şirket ismi
        [StringType(Max = 20, Min = 1)]
        public string BodyType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string TransmissionType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Color { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Year { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Version { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Hardware { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string FuelType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string KM { get; set; }
        public string[] Picture { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Description { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalSumTramer { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string ComissionPrice { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string NotaryPrice { get; set; }
        public bool BuyNowSell { get; set; } //hemen al sat aktifmi
        [StringType(Max = 20, Min = 1)]
        public string AdvertHeader { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string AdvertDescription { get; set; }
       // public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
       public TramerDTO Tramer { get; set; } 
        public List<CarStatuHistoryDTO> CarStatuHistory { get; set; }
      
    }
}
