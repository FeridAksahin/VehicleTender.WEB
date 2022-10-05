using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
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

        public async Task<string> PostAsync<T>(T data, string endpoint) where T : class
        {
            var convertedJsonParameterObject = new StringContent(JsonConvert.SerializeObject(data));
            convertedJsonParameterObject.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(endpoint, convertedJsonParameterObject);
            return response.Content.ReadAsStringAsync().Result == "Başarılı" ? "Ekleme Başarılı" : "Hata mevcut";
        }

 
    }
}