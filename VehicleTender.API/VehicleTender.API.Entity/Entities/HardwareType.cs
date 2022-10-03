using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("HardwareType")]
    public class HardwareType
    {
        [Key]
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public bool isActive { get; set; }
        public virtual List<Hardware> Hardware { get; set; }
    }
}
