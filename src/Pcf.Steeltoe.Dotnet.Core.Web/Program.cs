using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using Steeltoe.Extensions.Configuration.ConfigServer;

namespace Pcf.Steeltoe.Dotnet.Core.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseCloudFoundryHosting() //enables app to use port assigned to it by cloud foundry
                .AddCloudFoundry() //VCAP_APPLICATION & VCAP_SERVICES
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddConfigServer(context.HostingEnvironment);
                })
                .UseStartup<Startup>()
                .Build();
    }
}