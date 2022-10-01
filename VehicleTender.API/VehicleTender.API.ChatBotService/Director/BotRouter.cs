using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.ChatBotService.Builder;

namespace VehicleTender.API.ChatBotService.Director
{
    public class BotRouter
    {
        public void BotDirector(BotBuilder botBuilder)
        {
            botBuilder.buildBotCommands();
            botBuilder.buildBotDescription(); 
        }
    }
}
