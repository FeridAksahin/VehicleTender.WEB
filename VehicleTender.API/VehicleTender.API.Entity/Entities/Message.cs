using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    [Table("Message")]
    public class Message : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        [Column("UserMessage")]
        public string? UserMessage { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
