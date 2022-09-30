using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("VehicleStatuHistory")]
    public class VehicleStatuHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? StatuId { get; set; }

        public int? CarDetailInfoId { get; set; }

        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }
        [ForeignKey("StatuId")]
        public virtual Statu Statu { get; set; }
    }
}
