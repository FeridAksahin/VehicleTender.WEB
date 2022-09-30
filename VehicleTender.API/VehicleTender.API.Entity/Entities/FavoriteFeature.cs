using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("FavoriteFeature")]
    public class FavoriteFeature
    {
        [Key]
        public int Id { get; set; }
        public int? HardwareId { get; set; }
        [ForeignKey("HardwareId")]
        public virtual Hardware Hardware { get; set; }
        public int? FavoriteSearchCriteriaId { get; set; }
        [ForeignKey("FavoriteSearchCriteriaId")]
        public virtual FavoriteSearchCriteria FavoriteSearchCriteria { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
