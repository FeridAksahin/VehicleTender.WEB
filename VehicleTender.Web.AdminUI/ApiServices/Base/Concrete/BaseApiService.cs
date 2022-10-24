using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using VehicleTender.Web.AdminUI.ApiServices.Base.Interface;
using VehicleTender.Web.AdminUI.Models;
using VehicleTender.Web.AdminUI.Models.Token;
using VehicleTender.WEB.Admin.Common.WebScrap.CustomHTTPResponse;

namespace VehicleTender.Web.AdminUI.ApiServices.Base.Concrete
{
    public class BaseApiService : IBaseApiService
    {
        HttpClient client;
        public BaseApiService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7256/api/");
        }
        public async Task<BearerTokenDTO> GetToken(BearerTokenDTO bearerTokenDTO, UserLoginDTO getTokenForUser, string endpoint)
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(getTokenForUser));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(endpoint, convertedJsonParameterObject);
            return JsonConvert.DeserializeObject<BearerTokenDTO>(response.Content.ReadAsStringAsync().Result);
        }
        /*
        public async TokenDTO GetConvert<T>(string userName, string password, string endpoint,T whoWantNiceToken) where T : class
        {
            TokenDTO getTokenDeserialize;
            string res = GetToken(userName, password, endpoint).Result;
            whoWantNiceToken.SetToken = res;
            return getTokenDeserialize = JsonConvert.DeserializeObject<TokenDTO>(res);
        }*/
        public async Task<T> GetAsync<T>(BearerTokenDTO bearerTokenDTO, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            return null;
        }
        public async Task<T> GetAsync<T>(BearerTokenDTO bearerTokenDTO, string endpoint, string id) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync($"{endpoint}/{id}");
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public async Task<T> GetAsync<T, TSearch>(BearerTokenDTO bearerTokenDTO, string endpoint, string id) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync($"{endpoint}/{id}");
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public async Task<List<T>> GetAsyncList<T>(BearerTokenDTO bearerTokenDTO, string endpoint, T data) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<T>> GetAsyncList<T>(string endpoint) where T : class //tokensız test
        {
            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }



        public async Task<List<T>> GetAsyncList<T>(BearerTokenDTO bearerTokenDTO, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<List<T>> GetAsyncList<T>(BearerTokenDTO bearerTokenDTO, string endpoint, string request) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.GetAsync($"{endpoint}/{request}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<string> PostAsync<T>(BearerTokenDTO bearerTokenDTO, T data, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(endpoint, convertedJsonParameterObject);
            /*  return response.Content.ReadAsStringAsync().Result == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.GetHttpStatusCodes(201) :
                  statusGenerator.GetHttpStatusCodes(426);*/
            return response.Content.ReadAsStringAsync().Result;
            /*
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.GetHttpStatusCodes(201);
            else
                statusGenerator.GetHttpStatusCodes(429);
            */
        }

        public async Task<string> PostAsync<T>(T data, string endpoint) where T : class
        {

            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(endpoint, convertedJsonParameterObject);

            return response.Content.ReadAsStringAsync().Result;

        }

        public async Task<string> PostAsync<T>(BearerTokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(endpoint, convertedJsonParameterObject);
            // return response.Content.ReadAsStringAsync().Result == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.GetHttpStatusCodes(200) : statusGenerator.GetHttpStatusCodes(404);
            return response.Content.ReadAsStringAsync().Result;
        }
        public async Task<string> DeleteAsync(BearerTokenDTO bearerTokenDTO, string endpoint, int id)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var response = await client.DeleteAsync($"{endpoint}/{id}");
            /*  return response.Content.ReadAsStringAsync().Result == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.MakeCustomStatuCode(410, "Belirtilen veri başarıyla silindi") :
                  statusGenerator.MakeCustomStatuCode(403, "Buna yetkiniz yok");*/
            return response.Content.ReadAsStringAsync().Result;
            /*
            if (response.IsSuccessStatusCode)
                statusGenerator.MakeCustomStatuCode(410, "Belirtilen veri başarıyla silindi.");
            else
                statusGenerator.MakeCustomStatuCode(403, "Buna yetkiniz yok.");
            */
        }
        public async Task<string> PutAsync<T>(BearerTokenDTO bearerTokenDTO, T data, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PutAsync(endpoint, convertedJsonParameterObject);
            // return response.Content.ReadAsStringAsync().Result == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.GetHttpStatusCodes(201) : statusGenerator.GetHttpStatusCodes(404);
            return response.Content.ReadAsStringAsync().Result;
        }
        public async Task<string> PutAsync<T>(BearerTokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PutAsync(endpoint, convertedJsonParameterObject);
            //return response.Content.ReadAsStringAsync().Result == statusGenerator.GetHttpStatusCodes(200) ? statusGenerator.GetHttpStatusCodes(201) : statusGenerator.GetHttpStatusCodes(414); ;
            return response.Content.ReadAsStringAsync().Result;
        }


    }
}
