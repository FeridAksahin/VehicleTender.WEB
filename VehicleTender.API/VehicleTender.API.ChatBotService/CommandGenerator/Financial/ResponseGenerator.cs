using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.ChatBotService.CommandGenerator.Financial
{
    public class ResponseGenerator
    {
        Dictionary<RequestCommands, ResponseCommands> getResponseMessage = new Dictionary<RequestCommands, ResponseCommands>();
        public Dictionary<RequestCommands, ResponseCommands> GetResponse()
        {
            getResponseMessage.Add(RequestCommands.NotaryPriceInfo, ResponseCommands.NotaryPrice);
            getResponseMessage.Add(RequestCommands.EmergencyCardSituation, ResponseCommands.EmergencyCardSituationResponse);
            return getResponseMessage;
        }
    }
}
