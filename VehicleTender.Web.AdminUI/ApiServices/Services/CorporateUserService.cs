using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.CorporateUser;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class CorporateUserService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetCorporateUserDTO>> GetAllCorporateUser(Token token)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetCorporateUserDTO>> CorporateUserListBySearchFiltering(Token token, string packetName)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token, "endpoint route", packetName);
        }
        public async Task<GetCorporateUserDTO> CorporateUserByCompanyNameFiltering(Token token, string companyName)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsync<GetCorporateUserDTO>(token, "endpoint route", companyName);
        }
        public async Task<string> UpdateCorporateUserPacketType(Token token, CorporateUserPacketType updateCorporateUserPacket)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<CorporateUserPacketType>(token, updateCorporateUserPacket, "endpoint gelmeli");
        }
        public async Task<string> UpdateCorporateUserActiveOrDeactive(Token token, UpdateUserActiveOrDeactiveDTO updateCorporateisActive)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<UpdateUserActiveOrDeactiveDTO>(token, updateCorporateisActive, "endpoint gelmeli");
        }
    }
}
