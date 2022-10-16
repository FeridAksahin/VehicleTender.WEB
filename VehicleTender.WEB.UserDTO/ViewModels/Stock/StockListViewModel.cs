using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.Stock
{
    public class StockListViewModel
    {
        public int StockNo { get; set; }
        public string CompanyName { get; set; }
        public string VehicleCount { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}