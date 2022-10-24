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
        public async Task<string> BuyVehicleNow(Token tokenDTO, BuyAVehicleNowInput buyVehicleNowViewModel)
        {
            return await requestApiService.PostAsync<BuyAVehicleNowInput>(tokenDTO, buyVehicleNowViewModel, "endpointburayagelecek");
        }
        public async Task<List<CarListVM>> CarList(Token tokenDTO)
        {
            return await requestApiService.GetAsyncList<CarListVM>(tokenDTO, "burayaendpointgelecek");
        }
    }
}