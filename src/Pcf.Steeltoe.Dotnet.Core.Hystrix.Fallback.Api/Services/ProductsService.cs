using System.Collections.Generic;
using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Context;
using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Domain;

namespace Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext productsContext;

        public ProductsService(ProductsContext productsContext)
        {
            this.productsContext = productsContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = productsContext.Products;

            return products;
        }
    }
}