using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Commission;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class CommissionService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<CommissionDTO>> GetAllCommission(Token token)
        {//https://localhost:7011/Comission
            return await baseApiService.GetAsyncList<CommissionDTO>(token, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCommission(Token token, UpdateCommission commission)
        {//https://localhost:7011/Comission
            return await baseApiService.PutAsync<UpdateCommission>(token, commission, "endpoint gelmeli");
        }
        public async Task<string> DeleteCommission(Token token, int commissionId)
        {//https://localhost:7011/Comission
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", commissionId);
        }
        public async Task<string> AddNewCommission(Token token, CommissionDTO newCommission)
        {//https://localhost:7011/Comission
            return await baseApiService.PostAsync<CommissionDTO>(token, newCommission, "endpoint route gelmeli");
        }
        public async Task<CommissionDTO> GetCommissionById(Token token,string id)
        {
            return await baseApiService.GetAsync<CommissionDTO>(token, id, "endpoint buraya gelecek");
        }
    }
}
