using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.ChatBotService.CommandGenerator.Financial;

namespace VehicleTender.API.ChatBotService.Product
{
    public class Bot
    {
        public List<ResponseGenerator> BuildBotCommands { get; set; }
        public string BuildBotDescription { get; set; }
    }
}
