using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Notary;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class NotaryService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<NotaryDTO> GetNotary(Token token)
        {//https://localhost:7011/Notary
            return await baseApiService.GetAsync<NotaryDTO>(token, "endpoint route gelmeli");
        }
        public async Task<string> UpdateNotary(Token token, UpdateNotaryDTO updateNotary)
        {//https://localhost:7011/Notary
            return await baseApiService.PutAsync<UpdateNotaryDTO>(token, updateNotary, "endpoint gelmeli");
        }
    }
}
