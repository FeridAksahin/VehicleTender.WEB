using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("EnumPacket")]
    public class EnumPacket
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string? Name { get; set; }

        public virtual List<CorporateDetail> CorporateDetail { get; set; }

        public virtual List<PacketAuthority> PacketAuthority { get; set; }
        public virtual List<CompanyPacketHistory> CompanyPacketHistory { get; set; }
    }
}
