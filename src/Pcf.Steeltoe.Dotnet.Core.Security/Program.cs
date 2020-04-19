using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace Pcf.Steeltoe.Dotnet.Core.Security
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .AddCloudFoundry()
                .UseStartup<Startup>();
    }
}