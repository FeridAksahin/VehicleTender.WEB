using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("RoleAuthority")]
    public class RoleAuthority : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? RoleId { get; set; }

        public int? AuthorityId { get; set; }

        [ForeignKey("AuthorityId")]
        public virtual Authority Authority { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
