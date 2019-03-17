using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektKsiegarniBCity.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Category Product { get; set; }
        public virtual Order Order { get; set; }
    }
}