using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Stock;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class StockService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> FilterStock(TokenDTO tokenDTO,FilterStockVM filterStockViewModel)
        {
            return await requestApiService.PostAsync<FilterStockVM>(tokenDTO,filterStockViewModel,"endpointburayagelecek");
        }
        public async Task<List<StockListVM>> StockList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<StockListVM>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleInStockVM>> VehicleInStock(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleInStockVM>(tokenDTO,"endpointburayagelecek");
        }
    }
}