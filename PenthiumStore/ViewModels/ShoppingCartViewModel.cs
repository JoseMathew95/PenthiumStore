using PenthiumStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenthiumStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}