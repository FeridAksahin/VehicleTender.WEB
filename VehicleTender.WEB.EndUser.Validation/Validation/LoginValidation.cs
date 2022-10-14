using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels;
namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class LoginValidation : AbstractValidator<LoginViewModel>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
        }
    }
}
