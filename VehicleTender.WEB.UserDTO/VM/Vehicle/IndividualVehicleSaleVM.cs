using System.Collections.Generic;

namespace VehicleTender.WEB.UserDTO.VM.Vehicle
{
    public class IndividualVehicleSaleVM
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int BodyTypeId { get; set; }
        public int Year { get; set; }
        public int GearTypeId { get; set; }
        public int FuelTypeId { get; set; }
        public int ColorId { get; set; }
        public string Version { get; set; }
        public string HardwareId { get; set; }
        public string Kilometer { get; set; }
        public string[] Photos { get; set; }
        public string Description { get; set; }
        public decimal TenEvaluationPrice { get; set; }
        public int UserId { get; set; }
        public decimal OfficialOffer { get; set; }

        public List<TramerVM> TramerVM { get; set; }
        public int TramerPrice { get; set; }
    }
}
