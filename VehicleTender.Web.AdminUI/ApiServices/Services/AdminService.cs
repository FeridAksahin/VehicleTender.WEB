using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Admin;
using VehicleTender.Web.AdminUI.Models.Token;
using VehicleTender.WEB.Admin.Common.WebScrap.CustomHTTPResponse;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class AdminService
    {
        StatusGenerator statusGenerator = new StatusGenerator();
        BaseApiService baseApiService = new BaseApiService();
        public async Task<string> AddNewAdmin(BearerTokenDTO token, AddAdminDTO newAdminInformation)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.PostAsync(token, newAdminInformation, "endpoint route gelmeli");
        }
        public async Task<List<GetAdminDTO>> GetAllAdmin(BearerTokenDTO token)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.GetAsyncList<GetAdminDTO>(token, "endpoint route gelmeli");
        }
        public async Task<string> DeleteAdmin(BearerTokenDTO token, int id)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli",id) == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.GetHttpStatusCodes(201) :
              statusGenerator.GetHttpStatusCodes(426);
        }
        public async Task<GetAdminDTO> GetAdminById(BearerTokenDTO token, string id)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.GetAsync<GetAdminDTO>(token, id ,"endpoint route gelmeli");
        }
        public async Task<string> UpdateAdmin(BearerTokenDTO token, GetAdminDTO updateAdminInformation)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.PutAsync<GetAdminDTO>(token, updateAdminInformation, "endpoint route gelmeli");
        }
    }
}
