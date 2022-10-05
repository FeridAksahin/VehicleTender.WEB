using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
using VehicleTender.WEB.EndUser.Common;
using VehicleTender.WEB.EndUser.Common.CustomHTTPResponse;
using VehicleTender.WEB.UserDTO.Concrete;
//using VehicleTender.WEB.UserDTO.Token;

namespace VehicleTender.Web.EndUserUI.ApiService.RepoService
{
    public class RequestApiService : IRequestApiService, IDisposable
    {
        StatusGenerator statusGenerator = new StatusGenerator();
        private bool disposed = false;
        private static HttpClient httpClient;
        private readonly string _baseAddress;//api base adresi - https://localhost:44358/api/ gibi
                                             //  private readonly string _addressSuffix; //https://localhost:44358/api/userproc/ gibi

      /*  static public TokenDTO SetToken
        {
            set
            {
                if (value != null)
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + value.AccessToken);
            }
        }*/
        public RequestApiService(string baseAddress = null)
        {

            if (baseAddress == null)
                _baseAddress = ConfigurationManager.AppSettings["ApiUrl"];
            else
                _baseAddress = baseAddress;
                //     _addressSuffix = addressSuffix;
            httpClient = CreateHttpClient(_baseAddress);
        }
        public HttpClient CreateHttpClient(string serviceBaseAddress)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(serviceBaseAddress);
            return httpClient;
        }

        public static async Task<string> GetToken(UserLoginDTO getTokenForUser, string endpoint)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>( "grant_type", "password" ), //yetki kodu
                //new KeyValuePair<string, string>( "username", userName ),
                //new KeyValuePair<string, string> ( "Password", password )
            };
            HttpContent content = new FormUrlEncodedContent(pairs);
            using (HttpResponseMessage response = await httpClient.PostAsync(endpoint, content))
                return await response.Content.ReadAsStringAsync();
        }
        /*
        public async TokenDTO GetConvert<T>(string userName, string password, string endpoint,T whoWantNiceToken) where T : class
        {
            TokenDTO getTokenDeserialize;
            string res = GetToken(userName, password, endpoint).Result;
            whoWantNiceToken.SetToken = res;
            return getTokenDeserialize = JsonConvert.DeserializeObject<TokenDTO>(res);
        }*/
        public async Task<T> GetAsync<T>(string endpoint) where T : class
        {
            var response = await httpClient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<T> GetAsync<T>(string endpoint, string id) where T : class
        {
            var response = await httpClient.GetAsync($"{endpoint}/{id}");
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public async Task<List<T>> GetAsyncList<T>(string endpoint) where T : class
        {
            var response = await httpClient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<List<T>> GetAsyncList<T>(string endpoint, string request) where T : class
        {
            var response = await httpClient.GetAsync($"{endpoint}/{request}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<string> PostAsync<T>(T data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.GetHttpStatusCodes(201);
            else
                statusGenerator.GetHttpStatusCodes(429);
        }
        public async Task<string> PostAsync<T>(List<T> data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.GetHttpStatusCodes(201);
            else
                statusGenerator.GetHttpStatusCodes(404);
        }
        public async Task<string> DeleteAsync(string endpoint, int id)
        {
            var response = await httpClient.DeleteAsync($"{endpoint}/{id}");
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.MakeCustomStatuCode(410, "Belirtilen veri başarıyla silindi.");
            else
                statusGenerator.MakeCustomStatuCode(403, "Buna yetkiniz yok.");
        }
        public async Task<string> PutAsync<T>(T data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PutAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.GetHttpStatusCodes(201);
            else
                statusGenerator.GetHttpStatusCodes(404);
        }
        public async Task<string> PutAsync<T>(List<T> data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PutAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                statusGenerator.GetHttpStatusCodes(201);
            else
                statusGenerator.GetHttpStatusCodes(414);
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                if (httpClient != null)
                {
                    httpClient = null;
                    httpClient.Dispose();
                }
                disposed = true;
            }
        }
      
        public async Task<T> GetRequest<T>(string endpoint) where T : class
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string resp = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(resp);
            }
        }   
    }
}