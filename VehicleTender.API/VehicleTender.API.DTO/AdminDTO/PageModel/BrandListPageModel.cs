using VehicleTender.API.DTO.AdminDTO.Models.Car.CarFeatures.Brand;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class BrandListPageModel
    {
        public List<Brand> BrandList { get; set; }
        public UpdateBrand UpdateBrand { get; set; }
        public Brand Brand { get; set; }
    }
}
