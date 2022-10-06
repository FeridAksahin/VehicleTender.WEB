using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class VehicleService
    {
        private readonly RequestApiService _requestApiService;
        private readonly string _apiUrl;
        public VehicleService()
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            _requestApiService = new RequestApiService();
        }

        public async Task<List<VehicleListViewModel>> GetListAsync(GetVehicleListInput input)
        {
            string endpoint = _apiUrl + "Vehicle/GetIndex";
            if (input != null)
            {
                endpoint += "?marka=" + input.BrandId + "&model=" + input.ModelId + "&isIndividual=" + input.isIndividual + "&status=" + input.StatusId;
            }
            return await _requestApiService.GetRequest<List<VehicleListViewModel>>(endpoint);
        }
    }
}