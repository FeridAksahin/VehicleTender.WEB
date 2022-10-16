using System;
namespace VehicleTender.WEB.UserDTO.VM.Stock
{
    public class FilterStockVM
    {
        public string CompanyName { get; set; }
        public int VehicleCount { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
