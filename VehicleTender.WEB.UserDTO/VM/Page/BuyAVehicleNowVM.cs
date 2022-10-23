using System.Collections.Generic;
using VehicleTender.WEB.UserDTO.VM.Advert;

namespace VehicleTender.WEB.UserDTO.VM.Page
{
    public class BuyAVehicleNowVM
    {
        public BuyAVehicleNowInput Input { get; set; }
        public List<CarListVM> Cars { get; set; }
    }
}
