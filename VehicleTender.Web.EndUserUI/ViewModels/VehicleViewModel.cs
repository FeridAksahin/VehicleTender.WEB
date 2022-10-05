using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTender.Web.EndUserUI.ViewModels
{
    public class VehicleViewModel
    {
        public List<VehicleListViewModel> VehicleList { get; set; }
        public string BrandId { get; set; }
        public string ModelId { get; set; }
        public bool? isIndividual { get; set; }
        public string StatusId { get; set; }
    }
}