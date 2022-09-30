using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Notary")]
    public class Notary : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? NotaryPrice { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
    }
}
