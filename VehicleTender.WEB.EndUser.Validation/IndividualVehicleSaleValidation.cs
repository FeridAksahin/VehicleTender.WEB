using FluentValidation;
using VehicleTender.WEB.UserDTO.VM.Vehicle;

namespace VehicleTender.WEB.EndUser.Validation
{
    public class IndividualVehicleSaleValidation : AbstractValidator<IndividualVehicleSaleVM>
    {
        public IndividualVehicleSaleValidation()
        {
            RuleFor(x => x.BrandId).NotNull().WithMessage("Marka seçiniz!");
            RuleFor(x => x.ModelId).NotNull().WithMessage("Model seçiniz!");
            RuleFor(x => x.BodyTypeId).NotNull().WithMessage("Gövde tipi seçiniz!");
            RuleFor(x => x.Year).NotNull().WithMessage("Yıl seçiniz!");
            RuleFor(x => x.GearTypeId).NotNull().WithMessage("Vites tipi seçiniz!");
            RuleFor(x => x.FuelTypeId).NotNull().WithMessage("Yakıt tipi seçiniz!");
            RuleFor(x => x.Version).NotNull().WithMessage("Versiyon seçiniz!");
            RuleFor(x => x.HardwareId).NotNull().WithMessage("Donanım boş olamaz!");
            RuleFor(x => x.Photos).NotNull().WithMessage("Fotoğraf sayısı beş olmalıdır!");
            RuleFor(x => x.Kilometer).NotNull().WithMessage("Kilometre boş olamaz!");
            RuleFor(x => x.Description).NotNull().WithMessage("Açıklama boş olamaz!");
        }
    }
}
