namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class AddCarDTO
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string IndividualOrCorparate { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
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
        public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
        public AdvertInformationDTO AdvertInformation { get; set; }

    }
}
