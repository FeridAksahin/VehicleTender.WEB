using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Vehicle
{
    public class CarAddDto
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string Description { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Version { get; set; }
       
    }
}
