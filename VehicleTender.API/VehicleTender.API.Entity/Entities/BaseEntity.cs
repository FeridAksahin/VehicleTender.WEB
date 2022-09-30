using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    public abstract class BaseEntity
    {
        public bool? IsActive { get; set; } = true;
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
    }
}
