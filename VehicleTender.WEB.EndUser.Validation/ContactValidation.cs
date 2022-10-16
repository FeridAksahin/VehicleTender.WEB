using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.Contact;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class ContactValidation : AbstractValidator<ContactVM>
    {
        public ContactValidation()
        {
            RuleFor(x => x.MessageId).NotEmpty().WithMessage("Mesajınızı yazınız!");
        }
    }
}
