using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.ChatBotService.CommandGenerator.Financial
{
    public enum ResponseCommands
    {
        [Description("457 Lira")]
        NotaryPrice,
        [Description("Bilgileriniz mali işler departmanına aktarılmıştır. Sorun için üzgünüz. Kontroller sağlanmaya başladı.")]
        EmergencyCardSituationResponse
    }
}
