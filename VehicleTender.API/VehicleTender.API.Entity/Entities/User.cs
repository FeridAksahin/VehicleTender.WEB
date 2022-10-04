using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string? UserName { get; set; }

        [StringLength(150)]
        public string? Name { get; set; }

        [StringLength(150)]
        public string? Surname { get; set; }

        [StringLength(50)]
        public string? Telephone { get; set; }

        public string? Password { get; set; }

        public string? Mail { get; set; }

        public bool Kvkk { get; set; } = true;

        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
        public virtual List<IndividualVehiclePurchase> IndividualVehiclePurchase { get; set; }
        public virtual List<CorporateDetail> CorporateDetail { get; set; }
        public virtual List<IndividualVehicleSales> IndividualVehicleSales { get; set; }
        public virtual List<Log> Log { get; set; }
        public virtual List<Favorite> Favorite { get; set; }

        public virtual List<BuyingTenderVehicle> BuyingTenderVehicle { get; set; }

        public virtual List<Message> Message { get; set; }

        public virtual List<RoleUser> RoleUser { get; set; }
        [NotMapped]
        public virtual List<PurchasedVehicle> PurchasedVehicle { get; set; }
        public virtual List<TenderVehicleSales> TenderVehicleSales { get; set; }
        public virtual List<Stock> Stock { get; set; }
        public virtual List<CompanyPacketHistory> CompanyPacketHistory { get; set; }
    }
}
