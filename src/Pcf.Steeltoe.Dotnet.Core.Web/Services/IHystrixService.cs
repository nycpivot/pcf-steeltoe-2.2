using Pcf.Steeltoe.Dotnet.Core.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Services
{
    public interface IHystrixService
    {
        Task<IEnumerable<ProductViewModel>> GetWishlist();
        Task<IEnumerable<ProductViewModel>> GetProducts();
        void Crash();
    }
}