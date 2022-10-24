using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleTender.Web.EndUserUI.Models
{
    public class PostingSalesModel
    {
        [Required(ErrorMessage ="Boş geçilemez.")]
        public string BrandName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string ModelName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string BodyTypeName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        [Range(1990,2023,ErrorMessage ="Geçerli yıl giriniz.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string GearTypeName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string FuelTypeName { get; set; }
        [Required(ErrorMessage = "Boş geçileme.z")]
        public string ColorName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string VersionName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string HardwareName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string KM { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        [MinLength(30,ErrorMessage ="30 karakterden uzun giriş yapınız.")]
        [MaxLength(500,ErrorMessage ="500 karakterden kısa giriş yapınız.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public HttpPostedFileBase[] Photos { get; set; }
        public List<string> ImagePath { get; set; }
        [Required]
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