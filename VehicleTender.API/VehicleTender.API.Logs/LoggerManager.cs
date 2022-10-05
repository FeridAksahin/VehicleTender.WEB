using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DAL.Concrete;
using VehicleTender.API.DAL.Interface;
using VehicleTender.API.DTO.LogDTOs;

namespace VehicleTender.API.Logs
{
    public class LoggerManager : ILoggerManager
    {
        private ILogDAL _logDAL;
        public LoggerManager(LogDAL logDAL)
        {
            _logDAL = logDAL;
        }
        public void Log(LogDTO log_information)
        {
            _logDAL.AddLog();
        }
    }
}
