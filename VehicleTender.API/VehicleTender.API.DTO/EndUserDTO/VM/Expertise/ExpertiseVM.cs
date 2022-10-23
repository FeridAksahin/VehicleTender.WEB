using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Expertise
{
    public class ExpertiseVM
    {
        public int? Id { get; set; }
        public string ExpertiseCompanyName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}
