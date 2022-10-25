using System;

namespace VehicleTender.API.DTO.EndUserDTO.VM.User
{
    public class VehicleSoldVM
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime SoldDate { get; set; }
        public int SoldPrice { get; set; }
        public string Buyer { get; set; }
    }
}
