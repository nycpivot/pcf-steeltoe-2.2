using Microsoft.AspNetCore.Mvc;
using Pcf.Steeltoe.Dotnet.Core.Web.Commands;
using Pcf.Steeltoe.Dotnet.Core.Web.Services;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Controllers
{
    public class HystrixController : Controller
    {
        private readonly HystrixWishlistCommand hystrixWishlistCommand;

        public HystrixController(HystrixWishlistCommand hystrixWishlistCommand)
        {
            this.hystrixWishlistCommand = hystrixWishlistCommand;
        }

        public IActionResult Index()
        {
            ViewBag.Products = hystrixWishlistCommand.GetCustomerWishlist().Result;

            return View();
        }

        public void Delete()
        {
            hystrixWishlistCommand.Crash();
        }
    }
}