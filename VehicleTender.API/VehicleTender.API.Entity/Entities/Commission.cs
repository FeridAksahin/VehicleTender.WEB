using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{

    [Table("Commission")]
    public class Commission : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommissionPrice { get; set; }

        public DateTime? EndDate { get; set; }

        public int? CarDetailInfoId { get; set; }
        [ForeignKey("CarDetailInfoId")]
        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
    }

}
