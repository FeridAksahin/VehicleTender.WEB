using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Hardware")]
    public class Hardware : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
        public string HardwareName { get; set; }

    }
}

