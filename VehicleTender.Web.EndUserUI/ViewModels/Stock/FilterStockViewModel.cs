using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.Stock
{
    public class FilterStockViewModel
    {
        public string CompanyName { get; set; }
        public int VehicleCount { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}