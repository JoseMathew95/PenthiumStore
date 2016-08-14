namespace PenthiumStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PenthiumContext : DbContext
    {
        public PenthiumContext()
            : base("name=PenthiumConnection")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product>Products { get; set; }


        public virtual DbSet<Cart> Carts { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
