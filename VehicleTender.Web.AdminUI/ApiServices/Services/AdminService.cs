using VehicleTender.Web.AdminUI.ApiServices.Base;
using VehicleTender.Web.AdminUI.Models;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{ 
    public class AdminService
    {
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
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli",id);
        }
        public async Task<string> UpdateAdmin(BearerTokenDTO token, GetAdminDTO updateAdminInformation)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.PutAsync<GetAdminDTO>(token, updateAdminInformation, "endpoint route gelmeli");
        }
        public async Task<List<GetCorporateUserDTO>> GetAllCorporateUser(BearerTokenDTO token)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetCorporateUserDTO>> CorporateUserListBySearchFiltering(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.GetAsyncList<GetCorporateUserDTO>(token,"endpoint route", searchFilterValues);
        }
        public async Task<string> UpdateCorporateUserPacketType(BearerTokenDTO token, CorporateUserPacketType updateCorporateUserPacket)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<CorporateUserPacketType>(token, updateCorporateUserPacket, "endpoint gelmeli");
        }
        public async Task<string> UpdateCorporateUserActiveOrDeactive(BearerTokenDTO token, UpdateUserActiveOrDeactiveDTO updateCorporateisActive)
        {//https://localhost:7011/User/CorporateUsers
            return await baseApiService.PutAsync<UpdateUserActiveOrDeactiveDTO>(token, updateCorporateisActive, "endpoint gelmeli");
        }
        public async Task<List<GetCarDTO>> GetAllCar(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.GetAsyncList<GetCarDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetCarDTO>> GetCarsBySearchFilter(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.GetAsyncList<GetCarDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> UpdateCar(BearerTokenDTO token, GetCarDTO car)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.PutAsync<GetCarDTO>(token, car, "endpoint gelmeli");
        }
        public async Task<string> DeleteCar(BearerTokenDTO token, int carId)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", carId);
        }
        public async Task<string> AddNewCar(BearerTokenDTO token, AddAdminDTO newAdminInformation)
        {//https://localhost:7011/UserOperations/UserList
            return await baseApiService.PostAsync(token, newAdminInformation, "endpoint route gelmeli");
        }
    }
}
