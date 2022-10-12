using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.CorporateUser;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class CorporateUserService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetCorporateUserDTO>> GetAllCorporateUser(BearerTokenDTO token)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetCorporateUserDTO>> CorporateUserListBySearchFiltering(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> UpdateCorporateUserPacketType(BearerTokenDTO token, CorporateUserPacketType updateCorporateUserPacket)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<CorporateUserPacketType>(token, updateCorporateUserPacket, "endpoint gelmeli");
        }
        public async Task<string> UpdateCorporateUserActiveOrDeactive(BearerTokenDTO token, UpdateUserActiveOrDeactiveDTO updateCorporateisActive)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<UpdateUserActiveOrDeactiveDTO>(token, updateCorporateisActive, "endpoint gelmeli");
        }
    }
}
