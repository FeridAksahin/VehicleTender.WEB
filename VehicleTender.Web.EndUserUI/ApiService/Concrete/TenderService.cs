using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Tender;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class TenderService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> SearchTender(TokenDTO tokenDTO,SearchTenderViewModel searchTenderViewModel)
        {
            return await requestApiService.PostAsync<SearchTenderViewModel>(tokenDTO,searchTenderViewModel,"endpointburayagelecek");
        }
        public async Task<List<TenderListViewModel>> GetTenderList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<TenderListViewModel>(tokenDTO,"endpointburayagelecek");
        }
    }
}