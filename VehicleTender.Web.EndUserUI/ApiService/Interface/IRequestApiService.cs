using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.Web.EndUserUI.ApiService.Interface
{
    public interface IRequestApiService
    {
        HttpClient CreateHttpClient(string serviceBaseAddress);
        Task<List<T>> GetRequest<T>(string endpoint) where T : class;
        Task<string> PostAsync<T>(T data, string endpoint) where T : class;
    }
}
