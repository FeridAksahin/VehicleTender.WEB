using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels.Account;
using VehicleTender.Web.EndUserUI.ViewModels;
using VehicleTender.WEB.UserDTO.Concrete;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class AccountService
    {
        RequestApiService requestApiService = new RequestApiService("ApiUrl");
        public async Task<string> CorporateRegister(TokenDTO tokenDTO, CorporateRegisterViewModel corporateRegisterViewModel)
        {
            return await requestApiService.PostAsync<CorporateRegisterViewModel>(tokenDTO, corporateRegisterViewModel, "burayaendpointgelecek");
        }
        public async Task<string> Login(TokenDTO tokenDTO, LoginViewModel loginViewModel)
        {
            return await requestApiService.PostAsync<LoginViewModel>(tokenDTO, loginViewModel, "burayaendpointgelecek");
        }
        public async Task<string> Register(TokenDTO tokenDTO, RegisterViewModel registerViewModel)
        {
            return await requestApiService.PostAsync<RegisterViewModel>(tokenDTO, registerViewModel, "burayaendpointgelecek");
        }
        public async Task<string> ResetPassword(TokenDTO tokenDTO, ResetPasswordViewModel resetPasswordViewModel)
        {
            return await requestApiService.PutAsync<ResetPasswordViewModel>(tokenDTO, resetPasswordViewModel, "burayaendpointgelecek");
        }
    }
}