using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("EnumStatuType")]
    public class EnumStatuType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string? Type { get; set; }

        public virtual List<Statu> Statu { get; set; }
    }
}
