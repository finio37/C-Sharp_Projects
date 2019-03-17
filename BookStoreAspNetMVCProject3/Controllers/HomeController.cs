using ProjektKsiegarniBCity.DAL;
using ProjektKsiegarniBCity.ViewModels;
using ProjektKsiegarniBCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektKsiegarniBCity.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private StoreContext db = new StoreContext();
        public ActionResult Index()
        {
            var artykuly = db.Article.ToList();
            var categorie = db.Category.ToList();
            var wm = new HomeViewModel()
            {
                Artykuly = artykuly,
                Kategorie = categorie
            };
            return View(wm);
        }
        public ActionResult Index2()
        {
            return View();
        }
    }
}