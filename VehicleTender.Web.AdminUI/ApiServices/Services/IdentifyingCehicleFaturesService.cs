using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand;
using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Hardware;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class IdentifyingCehicleFaturesService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<string>> GetAllGearType(Token token)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewCarGearType(Token token, string gearType)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.PostAsync<string>(token, gearType, "endpoint route gelmeli");
        }
        public async Task<string> DeleteGearType(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }

        public async Task<List<string>> GetAllBodyType(Token token)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewCarBodyType(Token token, string bodyType)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.PostAsync<string>(token, bodyType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarBodyType(Token token, string idAndBodyType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.PutAsync<string>(token, idAndBodyType, "endpoint gelmeli");
        }
        public async Task<string> DeleteBodyType(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleBodyTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<Brand>> GetAllCarBrand(Token token)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.GetAsyncList<Brand>(token, "endpoint route");
        }
        public async Task<string> AddNewCarBrand(Token token, string brandName)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.PostAsync<string>(token, brandName, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarBrand(Token token, UpdateBrand updateBrand) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.PutAsync<UpdateBrand>(token, updateBrand, "endpoint gelmeli");
        }
        public async Task<string> DeleteCarBrand(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleBrandList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetAllColor(Token token)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewColor(Token token, string color)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.PostAsync<string>(token, color, "endpoint route gelmeli");
        }
        public async Task<string> UpdateColor(Token token, string idAndColor) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.PutAsync<string>(token, idAndColor, "endpoint gelmeli");
        }
        public async Task<string> DeleteColor(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleColorList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetFuelType(Token token)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewFuelType(Token token, string newFuelType)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.PostAsync<string>(token, newFuelType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateFuelType(Token token, string idAndFuelType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.PutAsync<string>(token, idAndFuelType, "endpoint gelmeli");
        }
        public async Task<string> DeleteFuelType(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleFuelTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetTransmissionType(Token token)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewTransmissionType(Token token, string newTransmissionType)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.PostAsync<string>(token, newTransmissionType, "endpoint route gelmeli");
        }
        public async Task<string> UpdateTransmissionType(Token token, string idAndTransmissionType) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.PutAsync<string>(token, idAndTransmissionType, "endpoint gelmeli");
        }
        public async Task<string> DeleteTransmissionType(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleGearTypeList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<Hardware>> GetAllHardware(Token token)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.GetAsyncList<Hardware>(token, "endpoint route");
        }
        public async Task<string> AddNewHardware(Token token, string newHardware)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.PostAsync<string>(token, newHardware, "endpoint route gelmeli");
        }
        public async Task<string> UpdateHardware(Token token, UpdateHardware updateHardware) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.PutAsync<UpdateHardware>(token, updateHardware, "endpoint gelmeli");
        }
        public async Task<string> DeleteHardware(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleHardwareList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<List<string>> GetCarModel(Token token)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.GetAsyncList<string>(token, "endpoint route");
        }
        public async Task<string> AddNewCarModel(Token token, string newCarModel)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.PostAsync<string>(token, newCarModel, "endpoint route gelmeli");
        }
        public async Task<string> UpdateCarModel(Token token, string idAndCarModel) //url kısmından gönderilip, api tarafında ayrılıp değerlendirilmeli
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.PutAsync<string>(token, idAndCarModel, "endpoint gelmeli");
        }
        public async Task<string> DeleteCarModel(Token token, int id)
        {//https://localhost:7011/Vehicle/VehicleModelList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
    }
}
