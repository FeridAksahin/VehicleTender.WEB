using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TramerSituationValue")]
    public class TramerSituationValue
    {
        [Key]
        public int Id { get; set; }

        public int? Situation { get; set; }

        public virtual List<TramerValue> TramerValue { get; set; }

    }
}
