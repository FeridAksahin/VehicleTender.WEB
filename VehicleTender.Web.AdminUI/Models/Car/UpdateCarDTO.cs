namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class UpdateCarDTO
    {
        public string CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string IndividualOrCorparate { get; set; }
        public double Price { get; set; }
        public double PreAssesmentPrice { get; set; }
        public string CompanyName { get; set; } //bireysel ise onun ismi kurumsalsa şirket ismi
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Version { get; set; }
        public string Hardware { get; set; }
        public string FuelType { get; set; }
        public string KM { get; set; }
        public string[] Picture { get; set; }
        public string Description { get; set; }
        public string Statu { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalSumTramer { get; set; }
        public string ComissionPrice { get; set; }
        public string NotaryPrice { get; set; }
        public bool BuyNowSell { get; set; } //hemen al sat aktifmi
        public string AdvertHeader { get; set; }
        public string AdvertDescription { get; set; }
        //--
        public string BuyerName { get; set; }
        public string BuyerSurname { get; set; }
        public string BuyerTelephone { get; set; }
        public string BuyerCompanyName { get; set; } //kurumsalsa
        public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
        public List<CarStatuHistoryDTO> CarStatuHistory { get; set; }
      
    }
}
