using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleTender.WEB.UserDTO.VM.Stock;

namespace VehicleTender.Web.EndUserUI.Models
{
    public class StockPageModel
    {
        public FilterStockVM filterStock { get; set; }
        public List<StockListVM> stockList { get; set; }
        public List<VehicleInStockVM> vehicleInStock { get; set; }
    }
}