using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Interface
{
    public interface IRequestApiService
    {
        HttpClient CreateHttpClient(string serviceBaseAddress);
        //get
        Task<List<T>> GetAsyncList<T>(string endpoint) where T : class;
        Task<T> GetAsync<T>(string endpoint, string id) where T : class;
        Task<List<T>> GetAsyncList<T>(string endpoint, string request) where T : class;
        //post
        Task<TokenDTO> GetToken(UserLoginDTO getTokenForUser, string endpoint);
        Task<string> PostAsync<T>(List<T> data, string endpoint) where T : class;
        Task<string> PostAsync<T>(T data, string endpoint) where T : class;
        //delete
        Task<string> DeleteAsync(string endpoint, int id);
        //put
        Task<string> PutAsync<T>(T data, string endpoint) where T : class;
        Task<string> PutAsync<T>(List<T> data, string endpoint) where T : class;
    }
}