using ProjektKsiegarniBCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektKsiegarniBCity.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}