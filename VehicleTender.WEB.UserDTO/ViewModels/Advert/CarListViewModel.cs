using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTender.Web.EndUserUI.ViewModels.Advert
{
    public class CarListViewModel
    {
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int BodyTypeId { get; set; }
        public int Year { get; set; }
        public int GearTypeId { get; set; }
        public int FuelTypeId { get; set; }
        public int ColorId { get; set; }
        public string Version { get; set; }
        public string HardwareId { get; set; }
        public string Kilometer { get; set; }
        public string[] Photos { get; set; }
        public string Description { get; set; }
    }
}