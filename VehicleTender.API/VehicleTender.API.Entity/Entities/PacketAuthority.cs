using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("PacketAuthority")]
    public class PacketAuthority : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? MonthlyTenderLimit { get; set; }

        public int? EnumPacketId { get; set; }
        [ForeignKey("EnumPacketId")]
        public virtual EnumPacket EnumPacket { get; set; }
    }
}
