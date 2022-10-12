using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Car;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class CarService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetCarDTO>> GetAllCar(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.GetAsyncList<GetCarDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetCarDTO>> GetCarsBySearchFilter(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.GetAsyncList<GetCarDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> DeleteCar(BearerTokenDTO token, int carId)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.DeleteAsync(token, "DeleteCar", carId);
        }
        public async Task<string> AddNewCar(BearerTokenDTO token, AddCarDTO newCarInformation)
        {//https://localhost:7011/Vehicle/AddVehicle
            return await baseApiService.PostAsync<AddCarDTO>(token, newCarInformation, "endpoint route gelmeli");
        }
        public async Task<UpdateCarDTO> GetCarDetailForIntoUpdateButton(BearerTokenDTO token, string id)
        {//https://localhost:7011/Vehicle/UpdateVehicle
            return await baseApiService.GetAsync<UpdateCarDTO>(token, "endpoint route", id);
        }
        public async Task<string> UpdateCar(BearerTokenDTO token, UpdateCarDTO car)
        {//https://localhost:7011/Vehicle/VehicleList
            return await baseApiService.PutAsync<UpdateCarDTO>(token, car, "endpoint gelmeli");
        }
    }
}
