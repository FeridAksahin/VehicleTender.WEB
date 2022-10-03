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
    public class Message 
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }
        public int? EnumMessageId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("EnumMessageId")]
        public virtual EnumMessage EnumMessage { get; set; }
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}
