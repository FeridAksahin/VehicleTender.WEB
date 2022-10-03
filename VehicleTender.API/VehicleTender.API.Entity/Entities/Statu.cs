using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Statu")]
    public class Statu
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string? Name { get; set; }

        public int? EnumStatuTypeId { get; set; }

        public virtual List<VehicleStatuHistory> VehicleStatuHistory { get; set; }
        [ForeignKey("EnumStatuTypeId")]
        public virtual EnumStatuType EnumStatuType { get; set; }

        public virtual List<TenderVehicleSales> TenderVehicleSales { get; set; }
        public virtual List<TenderStatuHistory> TenderStatuHistory { get; set; }
        List<IndividualVehicleSalesStatuHistory> IndividualVehicleSalesStatuHistory { get; set; }
    }
}
