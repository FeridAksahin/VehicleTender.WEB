using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Contact;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class ContactService
    {
        RequestApiService requestApiService = new RequestApiService();
        public async Task<string> Contact(Token tokenDTO, ContactVM contactViewModel)
        {
            return await requestApiService.PostAsync<ContactVM>(tokenDTO, contactViewModel, "endpointburayagelecek");
        }
    }
}