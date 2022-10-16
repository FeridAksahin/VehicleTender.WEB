using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.Account;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class ResetPasswordValidation : AbstractValidator<ResetPasswordVM>
    {
        public ResetPasswordValidation()
        {
            RuleFor(x => x.Mail).NotNull().WithMessage("Mail adresinizi giriniz!");
        }
    }
}
