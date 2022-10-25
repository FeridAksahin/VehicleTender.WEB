using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.UserDTO.VM.Vehicle
{
    public class PostingSalesAdvertisementVM
    {       
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string BodyTypeName { get; set; }
        public int Year { get; set; }
        public string GearTypeName { get; set; }
        public string FuelTypeName { get; set; }
        public string ColorName { get; set; }
        public string VersionName { get; set; }
        public string HardwareName { get; set; }
        public string KM { get; set; }
        public string Description { get; set; }
        public string[] ImagePath { get; set; }
        public decimal TramerTutarı { get; set; }
        public string SagArkaCamurluk { get; set; }
        public string ArkaKaput { get; set; }
        public string SolArkaCamurluk { get; set; }
        public string SagArkaKapı { get; set; }
        public string SagOnKapı { get; set; }
        public string Tavan { get; set; }
        public string SolArkaKapı { get; set; }
        public string SolOnKapı { get; set; }
        public string SagOnCamurluk { get; set; }
        public string MotorKaputu { get; set; }
        public string SolOnCamurluk { get; set; }
        public string OnTampon { get; set; }
        public string ArkaTampon { get; set; }
    }
}
