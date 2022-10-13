using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TenderVehicleBid")]
    public class TenderVehicleBid
    {
        [Key]
        public int Id { get; set; }
        public int? TenderVehicleDetailId { get; set; }
        public int? UserId { get; set; }
        public string Bid { get; set; }
        [ForeignKey("TenderVehicleDetailId")]
        public virtual TenderVehicleDetail TenderVehicleDetail { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
