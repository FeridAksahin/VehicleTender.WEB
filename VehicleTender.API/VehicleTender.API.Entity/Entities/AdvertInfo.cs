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

        public string? Description { get; set; }
        public int? CarDetailInfoId { get; set; }

        [StringLength(50)]
        public string? RightRearMudguard { get; set; }

        [StringLength(50)]
        public string? RearBonnet { get; set; }

        [StringLength(50)]
        public string? LeftRearMudguard { get; set; }

        [StringLength(50)]
        public string? RightRearDoor { get; set; }

        [StringLength(50)]
        public string? RightFrontDoor { get; set; }

        [StringLength(50)]
        public string? Ceiling { get; set; }

        [StringLength(50)]
        public string? LeftRearDoor { get; set; }

        [StringLength(50)]
        public string? LeftFrontDoor { get; set; }

        [StringLength(50)]
        public string? RightFrontMudguard { get; set; }

        [StringLength(50)]
        public string? EngineBonnet { get; set; }

        [StringLength(50)]
        public string? LeftFrontMudguard { get; set; }

        [StringLength(50)]
        public string? FrontBumper { get; set; }

        [StringLength(50)]
        public string? RearBumper { get; set; }

        [StringLength(50)]
        public string? TotalTramerPrice { get; set; }

        [ForeignKey("CarDetailInfoId")]
        public virtual List<CarDetailInfo> CarDetailInfo { get; set; }
        public virtual List<Favorite> Favorite { get; set; }
        public virtual List<Picture> Picture { get; set; }
    }
}
