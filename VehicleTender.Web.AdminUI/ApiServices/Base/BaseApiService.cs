using Newtonsoft.Json;
using System.Net.Http;
using VehicleTender.Web.AdminUI.Models;

namespace VehicleTender.Web.AdminUI.ApiServices.Base
{
    public class BaseApiService<T> :IBaseApiService<T> where T : class
    {
        private readonly HttpClient client;
        public BaseApiService(HttpClient httpClient)
        {
            client = httpClient;
        }
        public async Task<List<T>> GetAllAsync(BearerTokenDTO bearerTokenDTO, string requestUri)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var response = await client.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<T> GetAsync(BearerTokenDTO bearerTokenDTO, string requestUri, object id)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var response = await client.GetAsync($"{requestUri}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<T>> GetAllAsync(BearerTokenDTO bearerTokenDTO, string requestUri,object id)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var response = await client.GetAsync($"{requestUri}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<bool> Post(T item, BearerTokenDTO bearerTokenDTO, string requestUri)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var str = new StringContent(JsonConvert.SerializeObject(item));

            str.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(requestUri, str);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "Ok" ? true : false;
            } 
            return false;
        }

        public async Task<bool> Put(T item, BearerTokenDTO bearerTokenDTO, string requestUri)
        {

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var str = new StringContent(JsonConvert.SerializeObject(item));

            str.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync(requestUri, str);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "Ok" ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(T item, BearerTokenDTO bearerTokenDTO, string requestUri, object id)
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerTokenDTO.TokenUri}");

            var str = new StringContent(JsonConvert.SerializeObject(item));

            str.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.DeleteAsync($"{requestUri}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "Ok" ? true : false;
            }
            return false;
        }
    }
}
