using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.Account;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class LoginValidation : AbstractValidator<LoginVM>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez!");
            RuleFor(x => x.Username).MinimumLength(4).WithMessage("Kullanıcı adı en az dört karakterden oluşmalıdır!");


            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Şifre en az altı karakterden oluşmalıdır!");
        }
    }
}
