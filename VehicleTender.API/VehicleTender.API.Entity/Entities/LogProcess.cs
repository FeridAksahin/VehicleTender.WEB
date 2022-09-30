using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Entity.Entities
{
    public class LogProcess
    {
        [Key]
        public int Id { get; set; }
        public string? LogType { get; set; }
        public string? LogDescription { get; set; }
        public virtual List<Log> Log { get; set; }
    }
}
