using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Tender;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class TenderService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> SearchTender(TokenDTO tokenDTO,SearchTenderVM searchTenderViewModel)
        {
            return await requestApiService.PostAsync<SearchTenderVM>(tokenDTO,searchTenderViewModel,"endpointburayagelecek");
        }
        public async Task<List<TenderListVM>> GetTenderList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<TenderListVM>(tokenDTO,"endpointburayagelecek");
        }
    }
}