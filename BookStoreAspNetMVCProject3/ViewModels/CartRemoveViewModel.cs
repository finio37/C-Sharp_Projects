﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektKsiegarniBCity.ViewModels
{
    public class CartRemoveViewModel
    {
        public decimal CartTotal { get; set; }
        public int CartItemsCount { get; set; }
        public int RemoveItemCount { get; set; }
        public int RemoveItemId { get; set; }
    }
}