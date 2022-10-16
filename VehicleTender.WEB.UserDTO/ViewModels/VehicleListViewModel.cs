using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTender.Web.EndUserUI.ViewModels
{
    public class VehicleListViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string VehicleModel { get; set; }
        public string Statu { get; set; }
        public bool Bireysel { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}