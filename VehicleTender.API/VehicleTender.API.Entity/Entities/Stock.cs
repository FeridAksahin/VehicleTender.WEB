using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Stock")]
    public class Stock : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public int? CarDetailInfoId { get; set; }
        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }
        [ForeignKey("CustomerId")]
        public virtual User User { get; set; }
    }
}
