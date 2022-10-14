using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels.User;

namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class UserResetPasswordValidation : AbstractValidator<UserResetPasswordViewModel>
    {
        public UserResetPasswordValidation()
        {
            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Eski şifrenizi giriniz!");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Yeni şifrenizi giriniz!");
        }
    }
}
