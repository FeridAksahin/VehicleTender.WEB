using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.User;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class UserResetPasswordValidation : AbstractValidator<UserResetPasswordVM>
    {
        public UserResetPasswordValidation()
        {
            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Eski şifrenizi giriniz!");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Yeni şifrenizi giriniz!");
        }
    }
}
