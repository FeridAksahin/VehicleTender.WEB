using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("CorporateDetail")]
    public class CorporateDetail
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string? Province { get; set; }

        [StringLength(150)]
        public string? District { get; set; }

        public string? Adress { get; set; }

        public string? CompanyName { get; set; }

        public int? EnumCompanyTypeId { get; set; }

        public int? EnumPacketId { get; set; }
        [ForeignKey("EnumCompanyTypeId")]
        public virtual EnumCompanyType EnumCompanyType { get; set; }
        [ForeignKey("EnumPacketId")]
        public virtual EnumPacket EnumPacket { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
 