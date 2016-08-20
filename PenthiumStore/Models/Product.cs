/*
    modified by Jose Mathew
    http://penthiummobilestore.azurewebsites.net/
    this file defines the product table.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PenthiumStore.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }

        public virtual string Name { get; set; }

        
        public virtual int ManufacturerId { get; set; }

        
        public virtual int CategoryId { get; set; }

        public virtual decimal ProductPrice { get; set; }

        public virtual string ProductDescription { get; set; }

        public virtual string ProductImage { get; set; }

        public virtual bool ProductStock { get; set; }

        public virtual Manufacturer manufacturer { get; set; }

        public virtual Category category { get; set; }
    }
}