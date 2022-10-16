using System;
namespace VehicleTender.WEB.UserDTO.VM.Stock
{
    public class StockListVM
    {
        public int StockNo { get; set; }
        public string CompanyName { get; set; }
        public string VehicleCount { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
