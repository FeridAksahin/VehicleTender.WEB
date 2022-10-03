using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("IndividualVehicleSalesStatuHistory")]
    public class IndividualVehicleSalesStatuHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? IndividualVehicleSalesId { get; set; }
        public int? StatuId { get; set; }
        [ForeignKey("IndividualVehicleSalesId")]
        public virtual IndividualVehicleSales IndividualVehicleSales { get; set; }
        [ForeignKey("StatuId")]
        public virtual Statu Statu { get; set; }
 
    }
}
