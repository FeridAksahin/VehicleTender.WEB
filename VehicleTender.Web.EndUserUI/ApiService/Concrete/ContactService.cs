using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Contact;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class ContactService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> Contact(TokenDTO tokenDTO, ContactViewModel contactViewModel)
        {
            return await requestApiService.PostAsync<ContactViewModel>(tokenDTO, contactViewModel, "endpointburayagelecek");
        }
    }
}