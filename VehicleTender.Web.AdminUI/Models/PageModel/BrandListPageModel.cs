using VehicleTender.Web.AdminUI.Models.Car.CarFeatures.Brand;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class BrandListPageModel
    {
        public List<Brand> BrandList { get; set; }
        public UpdateBrand UpdateBrand { get; set; }
        public Brand Brand { get; set; }
    }
}
