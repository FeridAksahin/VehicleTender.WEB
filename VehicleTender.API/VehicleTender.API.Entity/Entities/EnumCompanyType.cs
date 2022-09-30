using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("EnumCompanyType")]
    public class EnumCompanyType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string? Type { get; set; }
        public List<CorporateDetail> CorporateDetail { get; set; }
    }
}
