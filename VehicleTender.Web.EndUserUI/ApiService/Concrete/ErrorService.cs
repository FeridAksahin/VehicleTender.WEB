using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Error;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class ErrorService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<ErrorViewModel> Error(TokenDTO tokenDTO,ErrorViewModel errorViewModel)
        {
            return await requestApiService.GetAsync<ErrorViewModel>(tokenDTO,"endpointburayagelecek");
        }
    }
}