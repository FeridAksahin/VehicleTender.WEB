using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("AdvertInfo")]
    public class AdvertInfo : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        [StringLength(20)]
        public string? KM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? CarDetailInfoId { get; set; }
        [StringLength(50)]
        public string? TotalTramerPrice { get; set; }

        [ForeignKey("CarDetailInfoId")]
        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
        public virtual List<Favorite> Favorite { get; set; }
        public virtual List<Picture> Picture { get; set; }
    }
}
