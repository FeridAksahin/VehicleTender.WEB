using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.Interface;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class RequestApiSerivce : IRequestApiService
    {
        private HttpClient httpClient;
        private readonly string _baseAddress;//api base adresi - https://localhost:44358/api/ gibi
      //  private readonly string _addressSuffix; //https://localhost:44358/api/userproc/ gibi
        public RequestApiSerivce(string baseAddress)
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
        public async Task<List<T>> GetRequest<T>(string endpoint) where T : class
        {
            var response = await httpClient.GetAsync(endpoint);  
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task GetRequest2(string endpoint)
        {
            var client = new HttpClient();

            var result = await client.GetAsync(endpoint);
        }
        public async Task<string> PostAsync<T>(T data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }

 
    }
}