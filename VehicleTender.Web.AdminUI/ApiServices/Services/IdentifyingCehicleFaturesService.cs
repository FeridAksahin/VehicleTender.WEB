using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class IdentifyingCehicleFaturesService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<string>> GetAllBodyType(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewCarBodyType(BearerTokenDTO token, string bodyType)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.PostAsync<string>(token, bodyType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarBodyType(BearerTokenDTO token, string idAndBodyType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.PutAsync<string>(token, idAndBodyType, "endpoint gelmeli");
        }
        public async Task<string> DeleteBodyType(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<Brand>> GetAllCarBrand(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.GetAsyncList<Brand>(token, "endpoint route");
        }
        public async Task<string> AddNewCarBrand(BearerTokenDTO token, string brandName)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.PostAsync<string>(token, brandName, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarBrand(BearerTokenDTO token, UpdateBrand updateBrand) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.PutAsync<UpdateBrand>(token, updateBrand, "endpoint gelmeli");
        }
        public async Task<string> DeleteCarBrand(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetAllColor(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewColor(BearerTokenDTO token, string color)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.PostAsync<string>(token, color, "endpoint route gelmeli");
        }
        public async Task<string> UpdateColor(BearerTokenDTO token, string idAndColor) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.PutAsync<string>(token, idAndColor, "endpoint gelmeli");
        }
        public async Task<string> DeleteColor(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetFuelType(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewFuelType(BearerTokenDTO token, string newFuelType)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.PostAsync<string>(token, newFuelType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateFuelType(BearerTokenDTO token, string idAndFuelType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.PutAsync<string>(token, idAndFuelType, "endpoint gelmeli");
        }
        public async Task<string> DeleteFuelType(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetTransmissionType(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewTransmissionType(BearerTokenDTO token, string newTransmissionType)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.PostAsync<string>(token, newTransmissionType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateTransmissionType(BearerTokenDTO token, string idAndTransmissionType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.PutAsync<string>(token, idAndTransmissionType, "endpoint gelmeli");
        }
        public async Task<string> DeleteTransmissionType(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<Hardware>> GetAllHardware(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.GetAsyncList<Hardware>(token, "endpoint route");
        }
        public async Task<string> AddNewHardware(BearerTokenDTO token, string newHardware)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.PostAsync<string>(token, newHardware, "endpoint route gelmeli");
        }
        public async Task<string> UpdateHardware(BearerTokenDTO token, UpdateHardware updateHardware) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.PutAsync<UpdateHardware>(token, updateHardware, "endpoint gelmeli");
        }
        public async Task<string> DeleteHardware(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetCarModel(BearerTokenDTO token)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewCarModel(BearerTokenDTO token, string newCarModel)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.PostAsync<string>(token, newCarModel, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarModel(BearerTokenDTO token, string idAndCarModel) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.PutAsync<string>(token, idAndCarModel, "endpoint gelmeli");
        }
        public async Task<string> DeleteCarModel(BearerTokenDTO token, int id)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
    }
}
