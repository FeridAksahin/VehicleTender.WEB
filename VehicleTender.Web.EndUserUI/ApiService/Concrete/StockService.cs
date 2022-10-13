using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Stock;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class StockService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> FilterStock(TokenDTO tokenDTO,FilterStockViewModel filterStockViewModel)
        {
            return await requestApiService.PostAsync<FilterStockViewModel>(tokenDTO,filterStockViewModel,"endpointburayagelecek");
        }
        public async Task<List<StockListViewModel>> StockList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<StockListViewModel>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleInStockViewModel>> VehicleInStock(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleInStockViewModel>(tokenDTO,"endpointburayagelecek");
        }
    }
}