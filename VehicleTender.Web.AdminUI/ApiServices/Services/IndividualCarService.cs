using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.IndividualCar;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class IndividualCarService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetIndividualCarSaleDTO>> GetAllIndividualCar(BearerTokenDTO token)
        {//https://localhost:7011/user/IndividualVehicleSalesList
            return await baseApiService.GetAsyncList<GetIndividualCarSaleDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<GetIndividualCarSaleDTO>> GetAllIndividualCarBySearchFiltering(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/user/IndividualVehicleSalesList
            return await baseApiService.GetAsyncList<GetIndividualCarSaleDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> DeleteIndividualCar(BearerTokenDTO token, int id)
        {//https://localhost:7011/user/IndividualVehicleSalesList
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", id);
        }
        public async Task<IndividualCarSaleUpdateDetailPageDTO> GetIndividualCarDetailForIntoUpdateButton(BearerTokenDTO token, string id)
        {//https://localhost:7011/user/IndividualVehicleSalesList
            return await baseApiService.GetAsync<IndividualCarSaleUpdateDetailPageDTO>(token, "endpoint route", id);
        }
        public async Task<string> UpdateIndividualCar(BearerTokenDTO token, IndividualCarSaleUpdateDetailPageDTO car)
        {//https://localhost:7011/user/IndividualVehicleSalesList
            return await baseApiService.PutAsync<IndividualCarSaleUpdateDetailPageDTO>(token, car, "endpoint gelmeli");
        }
    }
}
