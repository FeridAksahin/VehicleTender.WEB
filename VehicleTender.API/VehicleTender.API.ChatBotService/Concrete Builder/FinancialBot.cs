using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.ChatBotService.Builder;
using VehicleTender.API.ChatBotService.CommandGenerator.Financial;
using VehicleTender.API.ChatBotService.Product;

namespace VehicleTender.API.ChatBotService.Concrete_Builder
{
    public class FinancialBot : BotBuilder
    {
        RequestCommands request;
        ResponseMessage responseCommands;
        public FinancialBot(RequestCommands _request)
        {
            request = _request;
            bot = new Bot();
        }
      
        public override string buildBotCommands()
        {
            responseCommands = new ResponseMessage(request);
            var message = responseCommands.SendResponseMessage();
            return message;
        }

        public override string buildBotDescription()
        {
            return "";
        }
    }
}
