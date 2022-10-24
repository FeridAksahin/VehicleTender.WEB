using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Error;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class ErrorService
    {
        RequestApiService requestApiService = new RequestApiService();
        public async Task<ErrorVM> Error(Token tokenDTO,ErrorVM errorViewModel)
        {
            return await requestApiService.GetAsync<ErrorVM>(tokenDTO,"endpointburayagelecek");
        }
    }
}