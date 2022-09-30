using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("IndividualVehiclePurchase")]
    public class IndividualVehiclePurchase : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? UserIdBuyer { get; set; }
        public int? IndividualVehicleSalesId { get; set; }
        [ForeignKey("IndividualVehicleSalesId")]
        public virtual IndividualVehicleSales IndividualVehicleSales { get; set; }
        [ForeignKey("UserIdBuyer")]
        public virtual User User { get; set; }

    }
}
