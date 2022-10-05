namespace VehicleTender.Web.EndUserUI.ViewModels
{
    public class GetVehicleListInput
    {
        public string BrandId { get; set; }
        public string ModelId { get; set; }
        public bool? isIndividual { get; set; }
        public string StatusId { get; set; }
    }
}