using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("CarFeatureValue")]
    public class CarFeatureValue
    {
        [Key]
        public int Id { get; set; }
        public int? CarFeatureId { get; set; }
        public int? CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
        [ForeignKey("CarFeatureId")]
        public virtual CarFeature CarFeature { get; set; }
    }
}
