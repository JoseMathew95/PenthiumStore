/*
    modified by Jose Mathew
    http://penthiummobilestore.azurewebsites.net/
    this file defines the order details table.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PenthiumStore.Models
{
    public class OrderDetails
    {
        [Key]
        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Product product { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}