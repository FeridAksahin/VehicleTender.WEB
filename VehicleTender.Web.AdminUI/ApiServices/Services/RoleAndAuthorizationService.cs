using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.RoleAndAuthorization;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class RoleAndAuthorizationService
    {
        BaseApiService baseApiService = new BaseApiService();
        //rol page ekleme eksik
        public async Task<List<GetRoleAndAuthorizationDTO>> GetAllRoleAndAuthorization(Token token)
        {//https://localhost:7011/Admin/RoleAndAuthorization 
            return await baseApiService.GetAsyncList<GetRoleAndAuthorizationDTO>(token, "endpoint route");
        }
        public async Task<string> UpdateRoleAuthorization(Token token, RoleAuthorizationUpdateDTO updateRole)
        {//https://localhost:7011/Admin/RoleAndAuthorization
            return await baseApiService.PutAsync<RoleAuthorizationUpdateDTO>(token, updateRole, "endpoint gelmeli");
        }
        public async Task<string> DeleteRoleAuth(Token token, int id)
        {//https://localhost:7011/Admin/RoleAndAuthorization
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
    }
}
