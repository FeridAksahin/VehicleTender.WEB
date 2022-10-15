using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Validation.Attributes;

namespace VehicleTender.API.DTO
{
    public class TestDTO
    {
        [StringType(Max =12,Min =2)]
        public string name { get; set; }
        [DateType(MinimumYear =2000)]
        public DateTime date { get; set; }
        [EmailType(EmailValidateType =EmailValidateType.General)]
        public string Email { get; set; }



    }
}
