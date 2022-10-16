using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.Stock
{
    public class VehicleInStockViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Statu { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PreAssessmentPrice { get; set; } 
    }
}