using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Commission;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class CommissionService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<CommissionDTO>> GetAllCommission(BearerTokenDTO token)
        {//https://localhost:7011/Comission
            return await baseApiService.GetAsyncList<CommissionDTO>(token, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCommission(BearerTokenDTO token, UpdateCommission commission)
        {//https://localhost:7011/Comission
            return await baseApiService.PutAsync<UpdateCommission>(token, commission, "endpoint gelmeli");
        }
        public async Task<string> DeleteCommission(BearerTokenDTO token, int commissionId)
        {//https://localhost:7011/Comission
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", commissionId);
        }
        public async Task<string> AddNewCommission(BearerTokenDTO token, CommissionDTO newCommission)
        {//https://localhost:7011/Comission
            return await baseApiService.PostAsync<CommissionDTO>(token, newCommission, "endpoint route gelmeli");
        }
    }
}
