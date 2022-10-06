using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels;
using VehicleTender.WEB.UserDTO.Concrete;


namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{//Generic api servisi kullanım örnek
    public class CarService
    {
        RequestApiService requestApiService = new RequestApiService("https://localhost:7256/api/");
        static public TokenDTO SetToken
        {
            set
            {
                RequestApiService.SetToken = value;
            }
        }
        public async Task<List<CarDTO>> GetCarAsync()
        {
            return await requestApiService.GetAsyncList<CarDTO>("endpoint yolu gelmeli");

        }
        public async Task<TokenDTO> GetToken(UserLoginDTO userLoginDTO, string endpoint)
        {
            var jsonToken = await requestApiService.GetToken(userLoginDTO, endpoint);
            return SetToken = jsonToken;
        }
        public async Task<List<VehicleListViewModel>> GetListAsync(GetVehicleListInput input)
        {
            string endpoint = "Vehicle/GetIndex";
            if (input != null)
            {
                endpoint += "?marka=" + input.BrandId + "&model=" + input.ModelId + "&isIndividual=" + input.isIndividual + "&status=" + input.StatusId;
            }
            return await requestApiService.GetRequest<List<VehicleListViewModel>>(endpoint);
        }
        public void Dispose()
        {
            requestApiService.Dispose();
        }

    }
}


/*
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
 */