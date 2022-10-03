using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TramerValue")]
    public class TramerValue : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? TramerPartId { get; set; }
        public int? CarId { get; set; }
        public int? TramerSituationValueId { get; set; }

        [ForeignKey("TramerPartId")]
        public virtual TramerPart TramerPart { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("TramerSituationValueId")]
        public virtual TramerSituationValue TramerSituationValue { get; set; }

    }
}
