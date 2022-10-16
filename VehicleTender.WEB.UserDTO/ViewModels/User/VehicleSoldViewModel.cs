using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.User
{
    public class VehicleSoldViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime SoldDate { get; set; }
        public int SoldPrice { get; set; }
        public string Buyer { get; set; }
    }
}