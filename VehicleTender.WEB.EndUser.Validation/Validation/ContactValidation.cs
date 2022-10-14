using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels.Contact;
namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class ContactValidation : AbstractValidator<ContactViewModel>
    {
        public ContactValidation()
        {
            RuleFor(x => x.MessageId).NotNull().WithMessage("Mesajınızı yazınız!");
        }
    }
}
