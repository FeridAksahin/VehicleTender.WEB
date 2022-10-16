using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.Tender;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class SearchTenderValidation : AbstractValidator<SearchTenderVM>
    {
        public SearchTenderValidation()
        {
            RuleFor(x => x.TenderName).NotEmpty().WithMessage("İhale adı boş olmamalıdır!");
            RuleFor(x => x.StatuId).NotEmpty().WithMessage("Statü boş olmamalıdır!");
        }
    }
}
