using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TenderVehicleDetail")]
    public class TenderVehicleDetail : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? CarDetailInfoId { get; set; }
        public int? TenderVehicleSalesId { get; set; }
        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }
        [ForeignKey("TenderVehicleSalesId")]
        public virtual TenderVehicleSales TenderVehicleSales { get; set; }
        public virtual List<TenderVehicleBid> TenderVehicleBid { get; set; }
    }
}
