using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.LogDTOs;

namespace VehicleTender.API.Logs
{
    public interface ILoggerManager
    {
        void Log(LogDTO log_information);
    }
}
