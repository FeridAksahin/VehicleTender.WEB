using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.User;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class UserServices
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<List<FavoriteListVM>> FavoriteList(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<FavoriteListVM>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<string> Favorite(TokenDTO tokenDTO, FavoriteVM favoriteViewModel)
        {
            return await requestApiService.PostAsync<FavoriteVM>(tokenDTO,favoriteViewModel,"endpointburayagelecek");
        }
        public async Task<List<MyOffersVM>> MyOffers(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<MyOffersVM>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<string> UserResetPassword(TokenDTO tokenDTO, UserResetPasswordVM userResetPasswordViewModel)
        {
            return await requestApiService.PutAsync<UserResetPasswordVM>(tokenDTO,userResetPasswordViewModel, "endpointburayagelecek");
        }
        public async Task<UserVM> User(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsync<UserVM>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleBuyVM>> VehicleBuy(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleBuyVM>(tokenDTO,"endpointburayagelecek");
        }
        public async Task<List<VehicleSoldVM>> VehicleSold(TokenDTO tokenDTO)
        {
            return await requestApiService.GetAsyncList<VehicleSoldVM>(tokenDTO,"endpointburayagelecek");
        }
    }
}