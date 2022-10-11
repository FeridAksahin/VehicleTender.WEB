using System.Collections.Generic;

namespace VehicleTender.Web.EndUserUI.ViewModels.Vehicle
{
    public class IndividualVehicleSaleViewModel
    {
        public int Id { get; set; }
        // araç bilgileri gelecek
        public decimal TenEvaluationPrice { get; set; }
        public int UserId { get; set; }
        public decimal OfficialOffer { get; set; }

        public List<TramerViewModel> TramerViewModel { get; set; }
        public int TramerPrice { get; set; }
    }
}