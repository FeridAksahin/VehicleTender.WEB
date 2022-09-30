using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Authority")]
    public class Authority
    {
        [Key]
        public int Id { get; set; }

        public string? AuthorityName { get; set; }
    }
}
