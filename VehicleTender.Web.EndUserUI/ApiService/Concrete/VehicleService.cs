using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Vehicle;
using VehicleTender.Web.EndUserUI.ViewModels;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class VehicleService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> IndividualVehicleSale(TokenDTO tokenDTO,IndividualVehicleSaleViewModel individualVehicleSaleViewModel)
        {
            return await requestApiService.PostAsync<IndividualVehicleSaleViewModel>(tokenDTO, individualVehicleSaleViewModel, "endpointburayagelecek");
        }
        public async Task<string> Tramer(TokenDTO tokenDTO, TramerViewModel tramerViewModel)
        {
            return await requestApiService.PostAsync<TramerViewModel>(tokenDTO,tramerViewModel, "endpointburayagelecek");
        }
        //public async Task<List<VehicleListViewModel>> VehicleList(TokenDTO tokenDTO)
        //{
        //    return await requestApiService.GetAsyncList<VehicleListViewModel>(tokenDTO,"endpointburayagelecek");
        //}
        //public async Task<VehicleViewModel> Vehicle(TokenDTO tokenDTO)
        //{
        //    return await requestApiService.GetAsync<VehicleViewModel>(tokenDTO,"endpointburayagelecek");
        //}
    }
}