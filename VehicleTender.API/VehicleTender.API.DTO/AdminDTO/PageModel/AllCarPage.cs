using VehicleTender.API.DTO.AdminDTO.Models.Car;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class AllCarPage
    {
        public List<GetCarDTO> GetAllCar { get; set; }
        public UpdateCarDTO UpdateCarViewModel { get; set; }
    }
}
