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
        Task<List<T>> GetAsyncList<T>(TokenDTO bearerTokenDTO, string endpoint) where T : class;
        Task<T> GetAsync<T>(TokenDTO bearerTokenDTO, string endpoint, string id) where T : class;
        Task<List<T>> GetAsyncList<T>(TokenDTO bearerTokenDTO, string endpoint, string request) where T : class;
        //post
        Task<TokenDTO> GetToken(TokenDTO bearerTokenDTO, UserLoginDTO getTokenForUser, string endpoint);
        Task<string> PostAsync<T>(TokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class;
        Task<string> PostAsync<T>(TokenDTO bearerTokenDTO, T data, string endpoint) where T : class;
        //delete
        Task<string> DeleteAsync(TokenDTO bearerTokenDTO, string endpoint, int id);
        //put
        Task<string> PutAsync<T>(TokenDTO bearerTokenDTO, T data, string endpoint) where T : class;
        Task<string> PutAsync<T>(TokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class;
    }
}