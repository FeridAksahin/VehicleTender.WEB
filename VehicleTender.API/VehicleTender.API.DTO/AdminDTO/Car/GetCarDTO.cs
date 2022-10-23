using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Car
{
    public class GetCarDTO
    {

        public int CarId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string IndividualOrCorparate { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
