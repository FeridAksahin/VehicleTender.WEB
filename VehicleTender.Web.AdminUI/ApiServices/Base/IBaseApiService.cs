using VehicleTender.Web.AdminUI.Models;

namespace VehicleTender.Web.AdminUI.ApiServices.Base
{
    public interface IBaseApiService<T>
    {
        Task<List<T>> GetAllAsync(BearerTokenDTO bearerTokenDTO, string requestUri);
        Task<T> GetAsync(BearerTokenDTO bearerTokenDTO, string requestUri, object id);
        Task<List<T>> GetAllAsync(BearerTokenDTO bearerTokenDTO, string requestUri,object id);
        Task<bool> Post(T item, BearerTokenDTO bearerTokenDTO, string requestUri);
        Task<bool> Put(T item, BearerTokenDTO bearerTokenDTO, string requestUri);
        Task<bool> Delete(T item, BearerTokenDTO bearerTokenDTO, string requestUri, object id);

    }
}
