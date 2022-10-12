using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.User
{
    public class VehicleBuyViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime BuyDate { get; set; }
        public int BuyPrice { get; set; }
    }
}