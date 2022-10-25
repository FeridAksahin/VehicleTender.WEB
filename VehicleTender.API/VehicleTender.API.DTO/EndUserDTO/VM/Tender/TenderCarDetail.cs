using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Tender
{
    public class TenderCarDetail
    {
        public int CarId { get; set; } //teklif ver için lazım
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string FuelType { get; set; }
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public string Version { get; set; }
        public string KM { get; set; }
        public string Color { get; set; }
        public string Hardware { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Price { get; set; }
        public string AdvertDescription { get; set; }
        public string AdvertHead { get; set; }



    }
}
