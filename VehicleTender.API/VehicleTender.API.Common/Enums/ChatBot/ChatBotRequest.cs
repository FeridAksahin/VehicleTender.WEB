using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.Enums.ChatBot
{
    public enum ChatBotRequest
    {
        [Description("Mali İşler Botu Talebi")]
        FinancialAffairsBotRequest,
        [Description("Üye İşlemleri Bot Talebi")]
        MemberProcessBotRequest

        //daha gelicek bot tipleri mevcut
    }
}
