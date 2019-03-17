using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektKsiegarniBCity.Infrastructure
{
    public static class UrlHelpers
    {
        public static string PromocjeIconPath(this UrlHelper helper, string iconFileName)
        {
            var IconFolderPromotion = AppConfig.IconyPromocyjneRel;
            var path = Path.Combine(IconFolderPromotion, iconFileName);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }

        public static string NowosciIconPath(this UrlHelper helper, string iconNowoscName)
        {
            var IconFolderPromotion = AppConfig.IconyNowosciRel;
            var path = Path.Combine(IconFolderPromotion, iconNowoscName);
            var absoltePath = helper.Content(path);
            return absoltePath;
        }
        public static string ObcojezyczneIconPath(this UrlHelper helper, string iconObcoName)
        {
            var IconFolderObco = AppConfig.IconyObcojezyczneRel;
            var path = Path.Combine(IconFolderObco, iconObcoName);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
        public static string WszystkieIconyPath(this UrlHelper helper, string iconyWszystkie)
        {
            var IconFolder = AppConfig.IconyWszystkieRel;
            var path = Path.Combine(IconFolder, iconyWszystkie);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
        public static string CzasopismaIconyPath(this UrlHelper helper, string iconyCzasopism)
        {
            var IconFolder = AppConfig.IconyCzasopismaRel;
            var path = Path.Combine(IconFolder, iconyCzasopism);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
        public static string PrzecenaIconyPath(this UrlHelper helper, string iconyPrzecena)
        {
            var IconFolder = AppConfig.IconyPrzecenaRel;
            var path = Path.Combine(IconFolder, iconyPrzecena);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
        public static string AudiobookIconyPath(this UrlHelper helper, string iconyAudiobook)
        {
            var IconFolder = AppConfig.IconyAudiobookRel;
            var path = Path.Combine(IconFolder, iconyAudiobook);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}