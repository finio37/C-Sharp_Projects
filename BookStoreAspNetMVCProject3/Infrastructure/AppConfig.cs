using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjektKsiegarniBCity.Infrastructure
{
    public class AppConfig
    {
        private static string _iconyPromocyjneRel = ConfigurationManager.AppSettings["PromocjaConfigKey"];
        private static string _iconyNowosciRel = ConfigurationManager.AppSettings["NowosciConfigKey"];
        private static string _iconyObcojezyczneRel = ConfigurationManager.AppSettings["ObcojezyczneConfigKey"];
        private static string _iconyWszystkieRel = ConfigurationManager.AppSettings["ArticleConfigKey"];
        private static string _iconyCzasopismRel = ConfigurationManager.AppSettings["CzasopismaConfigKey"];
        private static string _iconyPrzecenaRel = ConfigurationManager.AppSettings["PrzecenaConfigKey"];
        private static string _iconyAudiobookRel = ConfigurationManager.AppSettings["AudiobookConfigKey"];
        public static string IconyPromocyjneRel
        {
            get
            {
                return _iconyPromocyjneRel;
            }
        }
        public static string IconyNowosciRel
        {
            get
            {
                return _iconyNowosciRel;
            }
        }
        public static string IconyObcojezyczneRel
        {
            get
            {
                return _iconyObcojezyczneRel;
            }
        }
        public static string IconyWszystkieRel
        {
            get
            {

                return _iconyWszystkieRel;
            }
        }
        public static string IconyCzasopismaRel
        {
            get
            {
                return _iconyCzasopismRel;
            }
        }
        public static string IconyPrzecenaRel
        {
            get
            {
                return _iconyPrzecenaRel;
            }
        }
        public static string IconyAudiobookRel
        {
            get {
                return _iconyAudiobookRel;
            }
        }
    }
}