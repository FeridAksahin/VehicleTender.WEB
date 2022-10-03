using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("CarFeatureCodeMeaning")]
    public class CarFeatureCodeMeaning
    {
        [Key]
        public int Id { get; set; }
        public string? CodeName { get; set; }
        public virtual List<CarFeature> CarFeature { get; set; }
    }
}
/*
 1                  2               3
FuelType         Transmission
 


olması gerekenler
---
BodyType
FuelType
TransmissionType
Color
Version

 */