using ProjektKsiegarniBCity.DAL;
using ProjektKsiegarniBCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektKsiegarniBCity.Infrastructure
{
    public class ShoppingCartManager
    {
        private ISessionManager session;
        private StoreContext db;
        public const string CartSessionKey = "CartData";
        public ShoppingCartManager(ISessionManager session, StoreContext db)
        {
            this.db = db;
            this.session = session;

        }
        public void AddToCart(int articleId)
        {
            var cart = this.GetCart();
            var cartItem = cart.Find(c => c.Article.ArticleId == articleId);
            if (cartItem != null)
                cartItem.Quantity++;
            else
            {
                var albumToAdd = db.Article.Where(a => a.ArticleId == articleId).SingleOrDefault();
                if (albumToAdd != null)
                {
                    var newCartItem = new CartItem()
                    {
                        Article = albumToAdd,
                        Quantity = 1,
                        TotalPrice = albumToAdd.Cena
                    };
                    cart.Add(newCartItem);

                }
            }
            session.Set(CartSessionKey, cart);
        }
        public List<CartItem> GetCart()
        {
            List<CartItem> cart;
            if (session.Get<List<CartItem>>(CartSessionKey) == null)
            {
                cart = new List<CartItem>();
            }
            else
            {
                cart = session.Get<List<CartItem>>(CartSessionKey) as List<CartItem>;
            }
            return cart;
        }
        public int RemoveFromCart(int articleId)
        {
            var cart = this.GetCart();
            var cartItem = cart.Find(c => c.Article.ArticleId == articleId);
            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    return cartItem.Quantity;
                }
                else
                    cart.Remove(cartItem);
            }
            return 0;
        }
        public decimal GetCartTotalPrice()
        {
            var cart = this.GetCart();
            return cart.Sum(c => (c.Quantity * c.Article.Cena));
        }
        public int GetCartItemsCount()
        {
            var cart = this.GetCart();
            int count = cart.Sum(c => c.Quantity);
            return count;
        }
        public Order CreateOrder(Order newOrder)
        {
            var cart = this.GetCart();
            newOrder.DateCreated = DateTime.Now;
            this.db.Orders.Add(newOrder);
            if (newOrder.OrderItems == null)
                newOrder.OrderItems = new List<OrderItem>();
            decimal cartTotal = 0;

            foreach (var cartItem in cart)
            {
                var newOrderItem = new OrderItem()
                {
                    ArticleId = cartItem.Article.ArticleId,
                    Quantity = cartItem.Quantity,
                    UnitPrice = cartItem.Article.Cena
                };
                cartTotal += (cartItem.Quantity * cartItem.Article.Cena);
                newOrder.OrderItems.Add(newOrderItem);
            }
            newOrder.TotalPrice = cartTotal;
            this.db.SaveChanges();
            return newOrder;
        }
        public void EmptyCard()
        {
            session.Set<List<CartItem>>(CartSessionKey, null);
        }

    }
}