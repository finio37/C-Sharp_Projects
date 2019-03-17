using ProjektKsiegarniBCity.DAL;
using ProjektKsiegarniBCity.Infrastructure;
using ProjektKsiegarniBCity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektKsiegarniBCity.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private ShoppingCartManager shopingCartManager;
        private ISessionManager sessionManager { get; set; }
        private StoreContext db = new StoreContext();
        public CartController()
        {
            this.sessionManager = new SessionManager();
            this.shopingCartManager = new ShoppingCartManager(this.sessionManager, this.db);
        }
        public ActionResult Index()
        {
            var cartItems = shopingCartManager.GetCart();
            var cartTotalPrice = shopingCartManager.GetCartTotalPrice();
            CartViewModel cartVM = new CartViewModel() { CartItems = cartItems, TotalPrice = cartTotalPrice };
            return View(cartVM);
        }
        public ActionResult AddToCart(int id)
        {
            shopingCartManager.AddToCart(id);

            return RedirectToAction("Index");
        }
        public int GetCartItemsCount()
        {
            return shopingCartManager.GetCartItemsCount();
        }
        public ActionResult RemoveFromCart(int id)
        {
            int itemCount = shopingCartManager.RemoveFromCart(id);
            int cartItemsCount = shopingCartManager.GetCartItemsCount();
            decimal cartTotal = shopingCartManager.GetCartTotalPrice();
            var result = new CartRemoveViewModel()
            {
                RemoveItemId = id,
                RemoveItemCount = itemCount,
                CartTotal = cartTotal,
                CartItemsCount = cartItemsCount
            };
            return Json(result); 
        }
    }
}