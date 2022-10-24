using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Account;

namespace VehicleTender.Web.EndUserUI.ApiService.Concrete
{
    public class AccountService
    {
        RequestApiService requestApiService = new RequestApiService();
        public async Task<string> CorporateRegister(Token tokenDTO, CorporateRegisterVM corporateRegisterViewModel)
        {
            return await requestApiService.PostAsync<CorporateRegisterVM>(tokenDTO, corporateRegisterViewModel, "burayaendpointgelecek");
        }
        public async Task<string> Login(Token tokenDTO, LoginVM loginViewModel)
        {
            return await requestApiService.PostAsync<LoginVM>(tokenDTO, loginViewModel, "burayaendpointgelecek");
        }
        public async Task<string> Register(Token tokenDTO, RegisterVM registerViewModel)
        {
            return await requestApiService.PostAsync<RegisterVM>(tokenDTO, registerViewModel, "burayaendpointgelecek");
        }
        public async Task<string> ResetPassword(Token tokenDTO, ResetPasswordVM resetPasswordViewModel)
        {
            return await requestApiService.PutAsync<ResetPasswordVM>(tokenDTO, resetPasswordViewModel, "burayaendpointgelecek");
        }
        public async Task<Token> GetToken(Token tokenDTO,LoginVM userLoginDTO)
        {
            return await requestApiService.GetToken(tokenDTO, userLoginDTO,"Auth/Login");
        }
    }
}