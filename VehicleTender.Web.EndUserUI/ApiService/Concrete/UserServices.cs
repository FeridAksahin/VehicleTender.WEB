using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.User;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class UserServices
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<List<FavoriteListViewModel>> FavoriteList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<FavoriteListViewModel>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<string> Favorite(TokenDTO tokenDTO, FavoriteViewModel favoriteViewModel)
        {
            return await requestApiService.PostAsync<FavoriteViewModel>(tokenDTO,favoriteViewModel,"endpointburayagelecek");
        }
        public async Task<List<MyOffersViewModel>> MyOffers(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<MyOffersViewModel>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<string> UserResetPassword(TokenDTO tokenDTO, UserResetPasswordViewModel userResetPasswordViewModel)
        {
            return await requestApiService.PutAsync<UserResetPasswordViewModel>(tokenDTO,userResetPasswordViewModel, "endpointburayagelecek");
        }
        public async Task<UserViewModel> User(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsync<UserViewModel>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleBuyViewModel>> VehicleBuy(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleBuyViewModel>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleSoldViewModel>> VehicleSold(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleSoldViewModel>(tokenDTO,"endpointburayagelecek");
        }
    }
}