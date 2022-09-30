using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TenderVehicleSales")]
    public class TenderVehicleSales : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? StatuId { get; set; }

        public string? TenderName { get; set; }

        public int? CarDetailInfoId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TenderStartingPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TenderMinumumPrice { get; set; }

        [StringLength(150)]
        public string? TenderEndHour { get; set; }

        [StringLength(150)]
        public string? TenderEndDate { get; set; }

        public bool? isItCorporate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TargetPrice { get; set; }

        public int? FavoriteCount { get; set; }

        [StringLength(50)]
        public string? TenderDuration { get; set; } //ihalede kalma süresi
        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }
        public virtual List<BuyingTenderVehicle> BuyingTenderVehicle { get; set; }
        [ForeignKey("StatuId")]
        public virtual Statu Statu { get; set; }
    }
}
