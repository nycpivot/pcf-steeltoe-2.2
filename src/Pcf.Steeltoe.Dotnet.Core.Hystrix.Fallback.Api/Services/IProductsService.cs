using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Domain;
using System.Collections.Generic;

namespace Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetProducts();
    }
}