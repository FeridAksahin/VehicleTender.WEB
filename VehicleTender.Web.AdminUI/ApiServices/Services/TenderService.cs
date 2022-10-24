using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Tender;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class TenderService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<GetTenderDTO>> TenderList() //token yok diye şuanlık çözüm
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.GetAsyncList<GetTenderDTO>("Tender/GetAll");
        }
        public async Task<List<GetTenderDTO>> TenderList(Token token)
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.GetAsyncList<GetTenderDTO>(token, "endpoint route");
        }
        public async Task<List<GetTenderDTO>> TenderListBySearchFiltering(Token token, string searchFilterValues)
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.GetAsyncList<GetTenderDTO>(token, "endpoint route", searchFilterValues);
        }
        public async Task<string> DeleteTender(Token token, int tenderId)
        {//https://localhost:7011/Tender/Tender
            return await baseApiService.DeleteAsync(token, "endpoint route gelmeli", tenderId);
        }
        public async Task<List<TenderCar>> GetTenderCarForAddTenderCar(Token token, string companyName)
        {//https://localhost:7011/tender/NewTenderCreate
            return await baseApiService.GetAsyncList<TenderCar>(token, "endpoint route", companyName);
        }
        public async Task<string> AddNewTender(Token token, AddNewTenderDTO newTender)
        {//https://localhost:7011/tender/NewTenderCreate
            return await baseApiService.PostAsync<AddNewTenderDTO>(token, newTender, "endpoint route gelmeli");
        }
        public async Task<UpdateTenderDTO> GetTenderById(Token token, string id)
        {//https://localhost:7011/Tender/UpdateTender
            return await baseApiService.GetAsync<UpdateTenderDTO>(token, "endpoint route gelmeli",id);
        }
        public async Task<string> UpdateTender(Token token, UpdateTenderDTO updateTender)
        {//https://localhost:7011/Tender/UpdateTender
            return await baseApiService.PutAsync<UpdateTenderDTO>(token, updateTender, "endpoint gelmeli");
        }
    }
}
