using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Advert;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class AdvertService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> BuyVehicleNow(TokenDTO tokenDTO, BuyVehicleNowVM buyVehicleNowViewModel)
        {
            return await requestApiService.PostAsync<BuyVehicleNowVM>(tokenDTO, buyVehicleNowViewModel, "endpointburayagelecek");
        }
        public async Task<List<CarListVM>> CarList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<CarListVM>(tokenDTO, "burayaendpointgelecek");
        }
    }
}