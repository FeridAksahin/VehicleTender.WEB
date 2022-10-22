using System.ComponentModel.DataAnnotations;
using VehicleTender.API.Validation.Attributes;
using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class AddCarDTO
    {
        public AddCarDTO()
        {
            Picture = new List<IFormFile>();
        }
        [StringType(Max = 20, Min = 2)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string IndividualOrCorparate { get; set; }
        [Range(0,10,ErrorMessage ="askjdhasd")]
        public double Price { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Name { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string BodyType { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string TransmissionType { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Color { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Year { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Version { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Hardware { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string FuelType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string KM { get; set; }
        public List<IFormFile> Picture { get; set; }
     
        [StringType(Max = 20, Min = 3)]
        public string Description { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 2)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalSumTramer { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string ComissionPrice { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string NotaryPrice { get; set; }
        //public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
        public TramerDTO Tramer { get; set; }
        public AdvertInformationDTO AdvertInformation { get; set; }
        public bool BuyNowSell { get; set; } //hemen al satışta
        public double PreAssesmentPrice { get; set; } //hemen al satışta

    }
}
