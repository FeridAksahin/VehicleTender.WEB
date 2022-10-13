using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Tender;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class TenderService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetTenderDTO>> TenderListBySearchFiltering(BearerTokenDTO token, string searchFilterValues)
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.GetAsyncList<GetTenderDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> DeleteTender(BearerTokenDTO token, int tenderId)
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", tenderId);
        }
        public async Task<List<TenderCar>> GetTenderCarForAddTenderCar(BearerTokenDTO token, string companyName)
        {//https://localhost:7011/tender/NewTenderCreate
            return await baseApiService.GetAsyncList<TenderCar>(token, "endpoint route", companyName);
        }
        public async Task<string> AddNewTender(BearerTokenDTO token, AddNewTenderDTO newTender)
        {//https://localhost:7011/tender/NewTenderCreate
            return await baseApiService.PostAsync<AddNewTenderDTO>(token, newTender, "endpoint route gelmeli");
        }
        public async Task<UpdateTenderDTO> GetTenderById(BearerTokenDTO token, string id)
        {//https://localhost:7011/Tender/UpdateTender
            return await baseApiService.GetAsync<UpdateTenderDTO>(token, id, "endpoint route gelmeli");
        }
        public async Task<string> UpdateTender(BearerTokenDTO token, UpdateTenderDTO updateTender)
        {//https://localhost:7011/Tender/UpdateTender
            return await baseApiService.PutAsync<UpdateTenderDTO>(token, updateTender, "endpoint gelmeli");
        }
    }
}
