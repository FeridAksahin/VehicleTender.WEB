namespace VehicleTender.Web.EndUserUI.ViewModels
{
    public class GetVehicleListInput
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool? isIndividual { get; set; }
        public string Status { get; set; }
    }
}