﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.BusinessLayer.Validation.Attributes;

namespace VehicleTender.API.DTO
{
    public class TestDTO
    {
        [StringType(Max =12,Min =2)]
        public string name { get; set; }
        [DateType(MinimumYear =2000)]
        public DateTime date { get; set; }
        [EmailType(EmailValidateType =EmailValidateType.Gmail)]
        public string Email { get; set; }



    }
}
