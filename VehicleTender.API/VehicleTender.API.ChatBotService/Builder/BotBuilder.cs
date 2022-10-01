using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.ChatBotService.CommandGenerator.Financial;
using VehicleTender.API.ChatBotService.Product;

namespace VehicleTender.API.ChatBotService.Builder
{
    public abstract class BotBuilder
    {
        public abstract string buildBotCommands();
        public abstract string buildBotDescription();
        
        protected Bot bot;
        public Bot Bot { get { return bot; } }
    }
}
