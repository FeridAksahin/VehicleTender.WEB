using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
using VehicleTender.WEB.EndUser.Common;

namespace VehicleTender.Web.EndUserUI.ApiService.RepoService
{
    public class RequestApiService : IRequestApiService, IDisposable
    {
        private bool disposed = false;
        private HttpClient httpClient;
        private readonly string _baseAddress;//api base adresi - https://localhost:44358/api/ gibi
      //  private readonly string _addressSuffix; //https://localhost:44358/api/userproc/ gibi
        public RequestApiService(string baseAddress)
        {
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
        public async Task<List<T>> GetAsyncList<T>(string endpoint) where T : class
        {
            var response = await httpClient.GetAsync(endpoint);  
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<T> GetAsync<T>(string endpoint, string id) where T : class
        {
            var response = await httpClient.GetAsync($"{endpoint}/{id}");
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
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
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }
        public async Task<string> PostAsync<T>(List<T> data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }
        public async Task<string> DeleteAsync(string endpoint, int id)
        {
            var response = await httpClient.DeleteAsync($"{endpoint}/{id}");
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }
        public async Task<string> PutAsync<T>(T data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PutAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }
        public async Task<string> PutAsync<T>(List<T> data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PutAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result;
 
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
    }
}