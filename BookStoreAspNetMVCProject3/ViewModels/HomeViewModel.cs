using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektKsiegarniBCity.Models;
namespace ProjektKsiegarniBCity.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Kategorie { get; set; }
       /* public IEnumerable<Article> Promocje { get; set; }
        public IEnumerable<Article> Nowosci { get; set; }
        public IEnumerable<Article> Obcojezyczne { get; set; }*/
        public IEnumerable<Article> Artykuly { get; set; }

    }
}