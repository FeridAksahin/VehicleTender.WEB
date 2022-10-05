using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
//using VehicleTender.WEB.UserDTO.Token;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{//Generic api servisi kullanım örnek
    public class CarService
    {
        RequestApiService requestApiService = new RequestApiService("https://localhost:7256/api/");
        /*static public TokenDTO SetToken
        {
            set
            {
                RequestApiService.SetToken = value;
            }
        }*/
        public async Task<List<CarDTO>> GetCarAsync()
        {
           return await requestApiService.GetAsyncList<CarDTO>("endpoint yolu gelmeli");
           
        }
        public TokenDTO rr(string name, string password, string endpoint)
        {
            TokenDTO niceToken = new TokenDTO();
            string jsonToken = RequestApiService.GetToken(name, password, endpoint).Result;
            niceToken = JsonConvert.DeserializeObject<TokenDTO>(jsonToken);
            return SetToken = niceToken;
        }
        public void Dispose()
        {
            requestApiService.Dispose();
        }

    }
}
