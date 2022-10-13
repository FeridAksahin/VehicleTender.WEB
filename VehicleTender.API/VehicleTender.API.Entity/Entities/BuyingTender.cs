using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("BuyingTender")] //ihale tüm araç alış
    public class BuyingTender : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? TenderVehicleSalesId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Offer { get; set; }

        public bool? IsItSold { get; set; }
        [ForeignKey("TenderVehicleSalesId")]
        public virtual TenderVehicleSales TenderVehicleSales { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
