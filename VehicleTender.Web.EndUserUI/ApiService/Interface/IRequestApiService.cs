using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Account;

namespace VehicleTender.Web.EndUserUI.ApiService.Interface
{
    public interface IRequestApiService
    {
        HttpClient CreateHttpClient(string serviceBaseAddress);
        //get
        Task<List<T>> GetAsyncList<T>(Token bearerTokenDTO, string endpoint) where T : class;
        Task<T> GetAsync<T>(Token bearerTokenDTO, string endpoint, string id) where T : class;
        Task<List<T>> GetAsyncList<T>(Token bearerTokenDTO, string endpoint, string request) where T : class;
        //post
        Task<Token> GetToken(Token bearerTokenDTO, LoginVM getTokenForUser, string endpoint);
        Task<string> PostAsync<T>(Token bearerTokenDTO, List<T> data, string endpoint) where T : class;
        Task<string> PostAsync<T>(Token bearerTokenDTO, T data, string endpoint) where T : class;
        //delete
        Task<string> DeleteAsync(Token bearerTokenDTO, string endpoint, int id);
        //put
        Task<string> PutAsync<T>(Token bearerTokenDTO, T data, string endpoint) where T : class;
        Task<string> PutAsync<T>(Token bearerTokenDTO, List<T> data, string endpoint) where T : class;
    }
}