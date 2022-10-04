using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("CarFeature")]
    public class CarFeature
    {
        [Key]
        public int Id { get; set; }
        public int? CarFeatureCodeMeaningId { get; set; }
        public string CarFeatureName { get; set; }
        [ForeignKey("CarFeatureCodeMeaningId")]
        public virtual CarFeatureCodeMeaning CarFeatureCodeMeaning { get; set; }
        public virtual List<CarFeatureValue> CarFeatureValue { get; set; }

    }
}
/*
 
CarFeatureCodeMeaningId 1           4           7

CarFeatureName          Benzinli   Düz Vites    Otomatik
tarzı
 */