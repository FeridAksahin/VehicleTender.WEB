using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Base.Interface
{
    public interface IBaseApiService
    {
        //get
        Task<List<T>> GetAsyncList<T>(Token bearerTokenDTO, string endpoint) where T : class;
        Task<T> GetAsync<T>(Token bearerTokenDTO, string endpoint, string id) where T : class;
        Task<List<T>> GetAsyncList<T>(Token bearerTokenDTO, string endpoint, string request) where T : class;
        //post
        Task<Token> GetToken(UserLoginDTO getTokenForUser, string endpoint);
        Task<string> PostAsync<T>(Token bearerTokenDTO, List<T> data, string endpoint) where T : class;
        Task<string> PostAsync<T>(Token bearerTokenDTO, T data, string endpoint) where T : class;
        //delete
        Task<string> DeleteAsync(Token bearerTokenDTO, string endpoint, int id);
        //put
        Task<string> PutAsync<T>(Token bearerTokenDTO, T data, string endpoint) where T : class;
        Task<string> PutAsync<T>(Token bearerTokenDTO, List<T> data, string endpoint) where T : class;

    }
}
