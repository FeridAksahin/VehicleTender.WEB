using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TenderStatuHistory")]
    public class TenderStatuHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string TenderName { get; set; }
        public int? StatuId { get; set; }
        [ForeignKey("StatuId")]
        public virtual Statu Statu { get; set; }
    }
}
