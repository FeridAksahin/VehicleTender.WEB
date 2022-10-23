using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.IndividualCar
{
    public class GetIndividualCarSaleDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string CarId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CreatedBy { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CreatedDate { get; set; }
    }
}
