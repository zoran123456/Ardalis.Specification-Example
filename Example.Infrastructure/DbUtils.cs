using Example.Core.ProductAggregate.Models;
using System.Linq;

namespace Example.Infrastructure
{
    public static class DbUtils
    {
        public static void SeedDb(DbContext db)
        {
            if (db.Products.Any())
                return;

            db.Products.Add(new Product { Id = 10, Name = "HP Spectre x360", Description = "Intel® Core™ i5-1135G7", Price = 1049 });
            db.Products.Add(new Product { Id = 20, Name = "Asus ROG Zephyrus G15", Description = "Ryzen 7 4800HS/16GB/SSD1TB/RTX2060", Price = 2279 });
            db.Products.Add(new Product { Id = 30, Name = "LG Gram 17", Description = "10th Gen Intel® Core™ processor with Iris® Plus graphics", Price = 1648 });
            db.Products.Add(new Product { Id = 40, Name = "Apple MacBook Pro 14", Description = "M1 Pro or M1 Max chip. Amazing battery life. And a 14” or 16” Liquid Retina XDR display", Price = 1999 });
            db.Products.Add(new Product { Id = 50, Name = "Dell XPS 13", Description = "11th Generation Intel® Core™ i3-1115G4 Processor", Price = 1299 });

            db.SaveChanges();
        }
    }
}
