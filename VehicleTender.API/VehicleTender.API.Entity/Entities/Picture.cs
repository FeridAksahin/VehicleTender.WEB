using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Picture")]
    public class Picture : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? AdvertInfoId { get; set; }

        public string? PicturePath { get; set; }
        [ForeignKey("AdvertInfoId")]
        public virtual AdvertInfo AdvertInfo { get; set; }
    }
}
