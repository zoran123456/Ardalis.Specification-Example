using Example.Core.ProductAggregate.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Infrastructure
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
              : base(options)
        {
            DbUtils.SeedDb(this);
        }

        public DbSet<Product> Products { get; set; }

    }
}
