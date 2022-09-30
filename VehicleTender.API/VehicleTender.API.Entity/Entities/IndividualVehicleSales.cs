using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("IndividualVehicleSales")]
    public class IndividualVehicleSales : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? CarDetailInfoId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TenEvaluationPrice { get; set; } //ön değerlendirme fiyatı

        public int? UserId { get; set; }

        [Column(TypeName = "money")]
        public decimal? OfficialOffer { get; set; }

        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual List<IndividualVehiclePurchase> IndividualVehiclePurchase { get; set; }
    }
}
