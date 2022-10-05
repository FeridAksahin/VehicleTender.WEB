using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.Enums;

namespace VehicleTender.API.DTO.LogDTOs
{
    public class LogDTO
    {
        public LogProcess LogProcess { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
    }
}
