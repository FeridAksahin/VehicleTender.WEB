using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("CarDetailInfo")]
    public class CarDetailInfo : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? AdvertInfoId { get; set; }

        public int? UserId { get; set; }

        public int? NotaryId { get; set; }
        public int? CarId { get; set; }

        public int? CommissionId { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }



        [ForeignKey("AdvertInfoId")]
        public virtual AdvertInfo AdvertInfo { get; set; }
        [ForeignKey("CommissionId")]
        public virtual Commission Commission { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("NotaryId")]
        public virtual Notary Notary { get; set; }


        public virtual List<VehicleStatuHistory> VehicleStatuHistory { get; set; }
        public virtual List<IndividualVehicleSales> IndividualVehicleSales { get; set; }
        public virtual List<TenderVehicleSales> TenderVehicleSales { get; set; }
        public virtual List<PurchasedVehicle> PurchasedVehicle { get; set; }
        public virtual List<Stock> Stock { get; set; }
    }
}
