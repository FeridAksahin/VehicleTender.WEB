using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.RestoreData;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class RestoreDataService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<RestoreDeletedDataDTO>> GetRestoreDeletedData(Token token)
        {//https://localhost:7011/General/RestoreDeletedData
            return await baseApiService.GetAsyncList<RestoreDeletedDataDTO>(token, "endpoint route");
        }
        public async Task<List<RestoreDeletedDataDTO>> GetRestoreDeletedDataBySearchFiltering(Token token, string searchFilterValues)
        {//https://localhost:7011/General/RestoreDeletedData
            return await baseApiService.GetAsyncList<RestoreDeletedDataDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> HardDeleteData(Token token, int id)
        {//https://localhost:7011/General/RestoreDeletedData
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<string> RestoreSoftDeleteData(Token token, string id)
        {//https://localhost:7011/General/RestoreDeletedData
            return await baseApiService.PutAsync(token, "endpoint route gelmeli", id);
        }
    }
}
