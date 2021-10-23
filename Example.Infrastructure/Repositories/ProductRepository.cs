using Ardalis.Specification.EntityFrameworkCore;
using Example.Core.ProductAggregate.Models;
using Example.Core.ProductAggregate.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Infrastructure.Repositories
{
    public class ProductRepository
    {
        private readonly DbContext dbContext;

        public ProductRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Product>> ListProducts()
        {
            return dbContext.Products.ToListAsync();
        }


        public Task<List<Product>> SearchForProductByName(string productName)
        {
            var spec = new SearchProductByNameSpec(productName);

            return dbContext.Products.ToListAsync(spec);
        }

        public Task<List<Product>> SearchForProductByDescription(string productDesc)
        {
            var spec = new SearchProductByDescSpec(productDesc);

            return dbContext.Products.ToListAsync(spec);
        }
    }
}
