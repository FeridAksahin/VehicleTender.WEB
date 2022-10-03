using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("TramerPart")]
    public class TramerPart
    {
        [Key]
        public int Id { get; set; }

        public string TramerPartName { get; set; }
        public int TramerPrice { get; set; }    
        public bool? isActive { get; set; }

        public virtual List<TramerValue> TramerValue { get; set; }
    }
}
/*
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

 */