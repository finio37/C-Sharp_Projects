using ProjektKsiegarniBCity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektKsiegarniBCity.Controllers
{
    public class StoreController : Controller
    {

        private StoreContext db = new StoreContext();
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var artykul = db.Article.Find(id);
            return View(artykul);
        }
        public ActionResult List(string kategorie)
        {
            // var kategoria = db.Category.Where(g => g.Name == kategName).Single();
            // var artykuly = kategoria.Articles.ToList();

            //var kategorie = db.Category.Include("Articles").Where(g => g.Name.ToUpper() == kategName.ToUpper()).Single();
            // var artykuly = kategorie.Articles.ToList();
            var news = db.Category.Include("Articles").Where(g => g.Name.ToUpper() == kategorie.ToUpper()).Single();
            var artnews = news.Articles.ToList();

            return View(artnews);
        }
        [ChildActionOnly]
        public ActionResult MenuCategories()
        {
            var kategorie = db.Category.ToList();
            return PartialView("_MenuCategories",kategorie);
        }
    }
}