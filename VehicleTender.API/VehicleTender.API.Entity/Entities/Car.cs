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
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? GearType { get; set; } //vites
        public string? BodyType { get; set; }
        public string? FuelType { get; set; }
        public string? Version { get; set; }
        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
        public virtual List<TramerValue> TramerValue { get; set; }
    }
}
