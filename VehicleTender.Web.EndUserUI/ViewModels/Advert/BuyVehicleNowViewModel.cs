using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.Advert
{
    public class BuyVehicleNowViewModel
    {
        // hemen araç al sayfasının filtreleme işlemi için kullanılır.
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string MinKilometer { get; set; }
        public string MaxKilometer { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public int GearTypeId { get; set; }
        public DateTime Date { get; set; }
        public int FuelTypeId { get; set; }
        public int Year { get; set; }
    }
}