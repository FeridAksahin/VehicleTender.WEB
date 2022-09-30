using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTender.API.Entity.Entities
{
    public class Log : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int LogProcessId { get; set; }
        public string? Page { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("LogProcessId")]
        public virtual LogProcess LogProcess { get; set; }

    }
}
