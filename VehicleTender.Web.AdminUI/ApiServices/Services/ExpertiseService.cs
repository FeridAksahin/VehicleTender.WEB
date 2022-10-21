using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Expertise;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class ExpertiseService
    {
        BaseApiService BaseApiService=new BaseApiService();

        public async Task<List<GetExpertise>> GetAllExpertise(BearerTokenDTO token)
        {
            return await BaseApiService.GetAsyncList<GetExpertise>(token, "endpointburayagelecek");
        }
        public async Task<List<GetExpertise>> GetExpertiseBySearch(BearerTokenDTO token,string searchFilterValues)
        {
            return await BaseApiService.GetAsyncList<GetExpertise>(token, "endpointburayagelecek",searchFilterValues);
        }
        public async Task<string> DeleteExpertise(BearerTokenDTO token,int id)
        {
            return await BaseApiService.DeleteAsync(token, "endpointburayagelecek",id);
        }
        public async Task<string> AddExpertise(BearerTokenDTO token,GetExpertise getExpertise)
        {
            return await BaseApiService.PostAsync<GetExpertise>(token,getExpertise, "endpointburayagelecek");
        }
        public async Task<GetExpertise> GetExpertiseDetailforIntoUpdateButton(BearerTokenDTO token,string id)
        {
            return await BaseApiService.GetAsync<GetExpertise>(token, "endpointburayagelecek",id);
        }
        public async Task<string> UpdateExpertise(BearerTokenDTO token,GetExpertise getExpertise)
        {
            return await BaseApiService.PutAsync<GetExpertise>(token,getExpertise, "endpointburayagelecek");
        }



    }
}
