using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.UserDTO.VM.HomeModel
{
    public class HomeAdvertViewModel
    {
        public int CarId { get; set; }
        public string AdvertHeader { get; set; }
        public string Model { get; set; }
        public string TransmissionType { get; set; }
        public string KM { get; set; }
        public string Photograph { get; set; }
        public string Status { get; set; }
    }
}
