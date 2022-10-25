using System;
namespace VehicleTender.WEB.UserDTO.VM.Stock
{
    public class VehicleInStockVM
    {
        public int? Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Statu { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PreAssessmentPrice { get; set; }
    }
}
