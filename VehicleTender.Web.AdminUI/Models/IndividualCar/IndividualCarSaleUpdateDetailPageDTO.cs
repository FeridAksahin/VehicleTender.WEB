using VehicleTender.Web.AdminUI.Models.Car;

namespace VehicleTender.Web.AdminUI.Models.IndividualCar
{
    public class IndividualCarSaleUpdateDetailPageDTO
    {//araç tarihçe eksik 
        public string MemberNameSurname { get; set; }
        public string Statu { get; set; }
        public string PreAssesmentPrice { get; set; }
        public string Offer { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string BodyType { get; set; }
        public string Year { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public string Version { get; set; }
        public string KM { get; set; }
        public string Color { get; set; }
        public string Hardware { get; set; }
        public string[] Picture { get; set; }
        public string Description { get; set; }
        public double TotalSumTramer { get; set; }
        public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
    }
}
