using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.DTO.Vehicle
{
    public class GetVehicleListInput
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public bool? isIndividual { get; set; }
        public string? Status { get; set; }
    }
}