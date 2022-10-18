using VehicleTender.Web.AdminUI.Models.Car;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class AllCarPage
    {
        public List<GetCarDTO> GetAllCar { get; set; }
        public UpdateCarDTO UpdateCarViewModel { get; set; }
    }
}
