using Ardalis.Specification.EntityFrameworkCore;
using Example.Core.ProductAggregate.Models;
using Example.Core.ProductAggregate.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Infrastructure.Repositories.GenericRepoExample
{
    public class ProductRepository : BaseRepository<Product>
    {
        public string ProductName { get; set; }

        public ProductRepository(DbContext dbContext) : base(dbContext) { }



        public override Task<List<Product>> Search()
        {
            if (string.IsNullOrWhiteSpace(ProductName))
                throw new ArgumentNullException(nameof(ProductName));

            var spec = new SearchProductByNameSpec(ProductName);

            return _dbContext.Products.ToListAsync(spec);

        }

    }

}
