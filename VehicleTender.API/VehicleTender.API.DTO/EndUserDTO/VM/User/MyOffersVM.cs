using System;

namespace VehicleTender.API.DTO.EndUserDTO.VM.User
{
    public class MyOffersVM
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime OfferDate { get; set; }
        public string OfferPrice { get; set; }
    }
}
