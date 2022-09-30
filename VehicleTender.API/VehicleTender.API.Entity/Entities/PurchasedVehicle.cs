using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("PurchasedVehicle")]
    public class PurchasedVehicle : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? SellerUserId { get; set; }

        public int? BuyerUserId { get; set; }

        public bool? isItTender { get; set; }

        public int? CarDetailInfoId { get; set; }
        [ForeignKey("CarDetailInfoId")]
        public virtual CarDetailInfo CarDetailInfo { get; set; }
        [ForeignKey("SellerUserId")]
        public virtual User SellerUser { get; set; }
        /* hata veriyor
        [ForeignKey("BuyerUserId")]
        public virtual User BuyerUser { get; set; }
        */
    }
}
