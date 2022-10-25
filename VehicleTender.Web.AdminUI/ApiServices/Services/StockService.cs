using VehicleTender.Web.AdminUI.ApiServices.Base.Concrete;
using VehicleTender.Web.AdminUI.Models.Stock;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Services
{
    public class StockService
    {
        BaseApiService baseApiService = new BaseApiService();
        public async Task<List<StockCompanyNameDTO>> GetAllStock(Token token)
        {//https://localhost:7011/Stock
            return await baseApiService.GetAsyncList<StockCompanyNameDTO>(token, "endpoint route gelmeli");
        }
        public async Task<List<StockDTO>> GetStockById(Token token, string companyNameOrId)
        {//https://localhost:7011/Stock
            return await baseApiService.GetAsyncList<StockDTO>(token, companyNameOrId, "endpoint route gelmeli");
        }
    }
}
