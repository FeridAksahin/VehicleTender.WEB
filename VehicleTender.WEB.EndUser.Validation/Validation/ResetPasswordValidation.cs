using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels.Account;
namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class ResetPasswordValidation : AbstractValidator<ResetPasswordViewModel>
    {
        public ResetPasswordValidation()
        {
            RuleFor(x => x.Mail).NotNull().WithMessage("Mail adresinizi giriniz!");
        }
    }
}
