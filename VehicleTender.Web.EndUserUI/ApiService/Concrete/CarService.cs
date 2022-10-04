using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{//Generic api servisi kullanım örnek
    public class CarService 
    {
        RequestApiService requestApiService = new RequestApiService("https://localhost:7256/api/");
        public async Task<List<CarDTO>> GetCarAsync()
        {
           return await requestApiService.GetAsyncList<CarDTO>("endpoint yolu gelmeli");
        }
        public void Dispose()
        {
            requestApiService.Dispose();
        }
   
    }
}
 