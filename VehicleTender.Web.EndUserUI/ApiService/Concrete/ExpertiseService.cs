using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Expertise;
using VehicleTender.WEB.UserDTO.VM.Stock;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class ExpertiseService
    {
        RequestApiService requestApiService = new RequestApiService();

        public async Task<List<ExpertiseVM>> GetAllExpertise(Token token)
        {
            return await requestApiService.GetAsyncList<ExpertiseVM>(token,"endpointburayagelecek");
        }
        public async Task<List<ExpertiseVM>> GetAllExpertise(Token token,string filter)
        {
            return await requestApiService.GetAsyncList<ExpertiseVM>(token,filter, "endpointburayagelecek");
        }
    }
}