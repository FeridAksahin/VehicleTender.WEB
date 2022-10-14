using FluentValidation;
using VehicleTender.Web.EndUserUI.ViewModels.Tender;

namespace VehicleTender.WEB.EndUser.Validation.Validation
{
    public class SearchTenderValidation : AbstractValidator<SearchTenderViewModel>
    {
        public SearchTenderValidation()
        {
            RuleFor(x => x.TenderName).NotEmpty().WithMessage("İhale adı boş olmamalıdır!");
            RuleFor(x => x.StatuId).NotEmpty().WithMessage("Statü boş olmamalıdır!");
        }
    }
}
