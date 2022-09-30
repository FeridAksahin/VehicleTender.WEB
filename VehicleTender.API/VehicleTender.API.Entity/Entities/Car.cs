using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Car")]
    public class Car : BaseEntity
    {//
        [Key]
        public int Id { get; set; }

        [StringLength(250)]//eğer marka girmek zorunlu ise [Required,StringLength(250,ErrorMessage="250 karakter olmalı.")]
        public string? Brand { get; set; }

        public int? Year { get; set; }

        [StringLength(250)]
        public string? Model { get; set; }

        [StringLength(250), DisplayName("Gövde Tipi")]
        public string? BodyType { get; set; }

        [StringLength(50)]
        public string? FuelType { get; set; }

        [StringLength(50)]
        public string? TransmissionType { get; set; } //vites tipi

        [StringLength(250)]
        public string? Version { get; set; }

        [StringLength(50)]
        public string? Color { get; set; }

        [StringLength(20)]
        public string? KM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
    }
}
