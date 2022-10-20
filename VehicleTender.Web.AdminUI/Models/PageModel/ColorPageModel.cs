using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Color;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class ColorPageModel
    {
        public Color Color { get; set; }
        public List<Color> GetColorList { get; set; }
    }
}
