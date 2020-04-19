using Microsoft.EntityFrameworkCore;
using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Domain;

namespace Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Context
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}