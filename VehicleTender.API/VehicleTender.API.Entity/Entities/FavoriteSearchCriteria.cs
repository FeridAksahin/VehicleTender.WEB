using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("FavoriteSearchCriteria")]
    public class FavoriteSearchCriteria
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public string KM { get; set; }
    }
}
