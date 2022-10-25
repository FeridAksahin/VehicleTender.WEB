namespace VehicleTender.API.DTO.EndUserDTO.VM.Advert
{
    public class CarListVM
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string GearType { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
        public string Version { get; set; }
        public string HardwareId { get; set; }
        public string Kilometer { get; set; }
        public string[] Photos { get; set; }
        public string Description { get; set; }
    }
}
