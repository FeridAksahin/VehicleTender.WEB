using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class TramerDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string RightRearFender { get; set; } //sağ arka çamurluk
        [StringType(Max = 20, Min = 1)]
        public string ReadHood { get; set; } //arka kaput
        [StringType(Max = 20, Min = 1)]
        public string LeftReadFender { get; set; } //sol arka çamurluk
        [StringType(Max = 20, Min = 1)]
        public string RightRearDoor { get; set; } // sağ arka kapı
        [StringType(Max = 20, Min = 1)]
        public string RightFrontDoor { get; set; } //sağ ön kapı
        [StringType(Max = 20, Min = 1)]
        public string Ceiling { get; set; } //tavan
        [StringType(Max = 20, Min = 1)]
        public string LeftReadDoor { get; set; } //sol arka kapı
        [StringType(Max = 20, Min = 1)]
        public string LeftFrontDoor { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string RightFrontFender { get; set; } //sağ ön çamurluk
        [StringType(Max = 20, Min = 1)]
        public string EngineBonnet { get; set; } //motor kaputu
        [StringType(Max = 20, Min = 1)]
        public string LeftFrontFender { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string FrontBumper { get; set; } //ön tampon
        [StringType(Max = 20, Min = 1)]
        public string RearBumper { get; set; } //arka tampon

    }
}
