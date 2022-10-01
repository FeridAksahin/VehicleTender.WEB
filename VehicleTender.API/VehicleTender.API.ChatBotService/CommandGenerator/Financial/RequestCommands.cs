using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.ChatBotService.CommandGenerator.Financial
{
    public enum RequestCommands
    {
        [Description("Noter ücreti ne kadar?")]
        NotaryPriceInfo,
        [Description("Kartımdan fazla para çekildi.")]
        EmergencyCardSituation

    }
}
