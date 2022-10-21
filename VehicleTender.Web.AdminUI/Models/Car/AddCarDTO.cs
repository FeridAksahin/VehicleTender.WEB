namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class AddCarDTO
    {
        public AddCarDTO()
        {
            Picture = new List<IFormFile>();
        }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string IndividualOrCorparate { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Version { get; set; }
        public string Hardware { get; set; }
        public string FuelType { get; set; }
        public string KM { get; set; }
        public List<IFormFile> Picture  { get; set; }
        public string Description { get; set; }
        public string Statu { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalSumTramer { get; set; }
        public string ComissionPrice { get; set; }
        public string NotaryPrice { get; set; }
        public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
        public AdvertInformationDTO AdvertInformation { get; set; }
        public bool SaleNow { get; set; } //hemen al satışta
        public double PreAssesmentPrice { get; set; } //hemen al satışta

    }
}
