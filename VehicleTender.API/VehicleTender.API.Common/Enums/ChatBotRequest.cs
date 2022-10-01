using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.Enums
{
    public enum ChatBotRequest
    {
        [Description("Mali İşler Botu Talebi")]
        MaliIslerBotuTalebi,
        [Description("Üye İşlemleri Bot Talebi")]
        UyeIslemlerBotuTalebi

            //daha gelicek bot tipleri mevcut
    }
}
