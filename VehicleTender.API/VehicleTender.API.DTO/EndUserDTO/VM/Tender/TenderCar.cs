using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Tender
{
    public class TenderCar
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string IndividualOrCorparate { get; set; }
        public string Statu { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Price { get; set; }
    }
}
