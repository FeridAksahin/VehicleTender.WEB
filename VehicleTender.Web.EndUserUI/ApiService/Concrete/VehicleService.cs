using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Vehicle;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class VehicleService
    {
        RequestApiService requestApiService = new RequestApiService();
        public async Task<string> IndividualVehicleSale(Token tokenDTO,IndividualVehicleSaleVM individualVehicleSaleViewModel)
        {
            return await requestApiService.PostAsync<IndividualVehicleSaleVM>(tokenDTO, individualVehicleSaleViewModel, "Vehicle/Create");
        }
        public async Task<string> Tramer(Token tokenDTO, TramerVM tramerViewModel)
        {
            return await requestApiService.PostAsync<TramerVM>(tokenDTO,tramerViewModel, "endpointburayagelecek");
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