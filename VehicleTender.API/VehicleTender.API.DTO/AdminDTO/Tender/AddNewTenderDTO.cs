using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.Tender
{
    public class AddNewTenderDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string TenderName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string IndividualOrCorparate { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CompanyName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        public DateTime TenderStartDate { get; set; }
        public DateTime TenderStartHour { get; set; }
        public DateTime TenderEndTime { get; set; }
        public DateTime TenderEndHour { get; set; }
        public List<TenderCarPriceAndTenderCar> VehiclesIdSelectedForInclusionInTheTender { get; set; }
        public List<TenderCar> GetAllCars { get; set; }
    }
}
