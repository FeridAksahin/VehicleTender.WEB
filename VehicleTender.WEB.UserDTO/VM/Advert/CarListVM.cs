namespace VehicleTender.WEB.UserDTO.VM.Advert
{
    public class CarListVM
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int BodyTypeId { get; set; }
        public string BodyTypeName { get; set; }
        public int Year { get; set; }
        public int GearTypeId { get; set; }
        public string GearTypeName { get; set; }
        public int FuelTypeId { get; set; }
        public string FuelTypeName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string Version { get; set; }
        public string HardwareId { get; set; }
        public string Kilometer { get; set; }
        public string[] Photos { get; set; }
        public string Description { get; set; }
    }
}
