using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramYepBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://telegramyepbot.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "extremecode_bot";

        public static string Key { get; set; }  = "657247879:AAHQrTnCVVOFS5C48oOUfeQvvnd8nov3isw";

    }
}