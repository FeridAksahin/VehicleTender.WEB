using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.ChatBotService.CommandGenerator.Financial
{
    public class ResponseMessage
    {
        ResponseGenerator responser;

        RequestCommands request;
        public ResponseMessage(RequestCommands _request)
        {
            request = _request;
        }

        public string SendResponseMessage()
        {
            responser = new ResponseGenerator();
            try
            {
                var getReponseMessage = responser.GetResponse()[request].ToString();
                return getReponseMessage;
            }
            catch
            { 
                return "";
                //error log
                //error message 
            }
      
          
        }
    }
}
