/*
    modified by Jose Mathew
    http://penthiummobilestore.azurewebsites.net/
    this file defines the Manufacturer table.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenthiumStore.Models
{
    public class Manufacturer
    {
        public virtual int ManufacturerId { get; set; }

        public virtual string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}