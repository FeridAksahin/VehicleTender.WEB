using VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Color;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class ColorPageModel
    {
        public Color Color { get; set; }
        public List<Color> GetColorList { get; set; }
    }
}
