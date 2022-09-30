using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Role")]
    public class Role : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? RoleName { get; set; }
        public virtual List<RoleAuthority> RoleAuthority { get; set; }
        public virtual List<RoleUser> RoleUser { get; set; }
    }
}
