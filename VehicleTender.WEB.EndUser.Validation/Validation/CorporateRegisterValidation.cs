using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels;

namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class CorporateRegisterValidation : AbstractValidator<CorporateRegisterViewModel>
    {
        public CorporateRegisterValidation()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
            RuleFor(x => x.Username).MinimumLength(4).WithMessage("Kullanıcı adı en az dört karakterden oluşmalıdır!");
            RuleFor(x => x.Username).MaximumLength(15).WithMessage("Kullanıcı adı en fazla on beş karakterden oluşmalıdır!");


            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş olamaz!");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage("Ad en az üç karakterden oluşmalıdır!");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(20).WithMessage("Ad en fazla yirmi karakterden oluşmalıdır!");


            RuleFor(x => x.Surname).NotEmpty().WithMessage("Ad boş olamaz!");
            RuleFor(x => x.Surname).NotEmpty().MinimumLength(3).WithMessage("Ad en az üç karakterden oluşmalıdır!");
            RuleFor(x => x.Surname).NotEmpty().MaximumLength(20).WithMessage("Ad en fazla yirmi karakterden oluşmalıdır!");


            RuleFor(x => x.Telephone).NotEmpty().WithMessage("Telefon boş geçilemez!");
            RuleFor(x => x.Telephone).NotEmpty().Length(10, 10);


            RuleFor(x => x.Mail).NotEmpty().EmailAddress();


            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz!");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(6).WithMessage("Şifre en az 6 karakterden oluşmalıdır!");
            RuleFor(x => x.Password).NotEmpty().MaximumLength(20).WithMessage("Şifre en fazla yirmi karakterden oluşmalıdır!");


            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir seçiniz!");


            RuleFor(x => x.District).NotEmpty().WithMessage("İlçe seçiniz!");


            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres boş olamaz!");


            RuleFor(x => x.CompanyName).NotNull().WithMessage("Şirket adı boş olamaz!");
            RuleFor(x => x.CompanyName).MinimumLength(3).WithMessage("Şirket adı en az üç karakter olmalıdır!");
            RuleFor(x => x.CompanyName).MaximumLength(20).WithMessage("Şirket adı en az fazla karakter olmalıdır!");


            RuleFor(x => x.CompanyType).NotNull().WithMessage("Şirket türünü seçiniz!");


            RuleFor(x => x.Kvkk).NotEmpty().WithMessage("Gizlilik sözleşmesi onaylanmalıdır!");
        }
    }
}
