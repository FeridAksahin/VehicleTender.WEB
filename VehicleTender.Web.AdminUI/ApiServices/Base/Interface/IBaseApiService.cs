using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.ApiServices.Base.Interface
{
    public interface IBaseApiService
    {
        //get
        Task<List<T>> GetAsyncList<T>(BearerTokenDTO bearerTokenDTO, string endpoint) where T : class;
        Task<T> GetAsync<T>(BearerTokenDTO bearerTokenDTO, string endpoint, string id) where T : class;
        Task<List<T>> GetAsyncList<T>(BearerTokenDTO bearerTokenDTO, string endpoint, string request) where T : class;
        //post
        Task<BearerTokenDTO> GetToken(UserLoginDTO getTokenForUser, string endpoint);
        Task<string> PostAsync<T>(BearerTokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class;
        Task<string> PostAsync<T>(BearerTokenDTO bearerTokenDTO, T data, string endpoint) where T : class;
        //delete
        Task<string> DeleteAsync(BearerTokenDTO bearerTokenDTO, string endpoint, int id);
        //put
        Task<string> PutAsync<T>(BearerTokenDTO bearerTokenDTO, T data, string endpoint) where T : class;
        Task<string> PutAsync<T>(BearerTokenDTO bearerTokenDTO, List<T> data, string endpoint) where T : class;

    }
}
