using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PenthiumStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<PenthiumContext>
    {
        protected override void Seed(PenthiumContext context)
        {
            var category = new List<Category>
            {
                new Category { Name = "Mobile Cases" },
                new Category { Name = "Screen Protectors" },
                new Category { Name = "Head Phones" },
                new Category { Name = "Memory" }

            };

            var manufacturer = new List<Manufacturer>
            {
                new Manufacturer { Name = "Samsung" },
                new Manufacturer { Name = "Apple" },
                new Manufacturer { Name = "LG" },
                new Manufacturer { Name = "Blackberry" }

            };

            new List<Product>
            {
                new Product { Name = "Apple iphone 5 - case", manufacturer = manufacturer.Single(g => g.Name == "Apple"), category = category.Single(s => s.Name == "Mobile Cases"), ProductPrice = 25.00m, ProductDescription = "Apple cases", ProductImage = "AppleCase-5.jpg", ProductStock = true  },
                new Product { Name = "Samsung s5 - headphone", manufacturer = manufacturer.Single(g => g.Name == "Samsung"), category = category.Single(s => s.Name == "Head Phones"), ProductPrice = 85.00m, ProductDescription = "Head Phones", ProductImage = "samsung headphone-5.jpg", ProductStock = true  },
            }.ForEach(a => context.Products.Add(a));

        }
    }
}