using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Advert;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class AdvertService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> BuyVehicleNow(TokenDTO tokenDTO, BuyVehicleNowViewModel buyVehicleNowViewModel)
        {
            return await requestApiService.PostAsync<BuyVehicleNowViewModel>(tokenDTO, buyVehicleNowViewModel, "endpointburayagelecek");
        }
        public async Task<List<CarListViewModel>> CarList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<CarListViewModel>(tokenDTO, "burayaendpointgelecek");
        }
    }
}