using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Controllers.Config
{
    public class AppSettingsController : Controller
    {
        private readonly IConfiguration configuration;

        public AppSettingsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.ConnectionString = configuration["ConnectionString"];

            return View();
        }
    }
}