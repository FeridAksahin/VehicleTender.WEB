using System.Collections.Generic;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Page
{
    public class BuyAVehicleNowVM
    {
        public BuyAVehicleNowInput Input { get; set; }
        public List<CarListVM> Cars { get; set; }
    }
}
