using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Expertise")]
    public class Expertise : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Province { get; set; } //il

        public string? District { get; set; } //ilçe

        public string? Link { get; set; }
    }
}
