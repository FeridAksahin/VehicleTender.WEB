using System;

namespace VehicleTender.API.DTO.EndUserDTO.VM.User
{
    public class VehicleBuyVM
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime BuyDate { get; set; }
        public int BuyPrice { get; set; }
    }
}
