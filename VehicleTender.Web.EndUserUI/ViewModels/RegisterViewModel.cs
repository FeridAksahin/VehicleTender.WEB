﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTender.Web.EndUserUI.ViewModels
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
    }
}