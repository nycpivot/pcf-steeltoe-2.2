using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Context;
using Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api.Services;
using Steeltoe.CloudFoundry.Connector.SqlServer.EFCore;
using Steeltoe.Discovery.Client;

namespace Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDiscoveryClient(Configuration);

            services.AddSingleton<IProductsService, ProductsService>();

            services.AddDbContext<ProductsContext>(options => options.UseSqlServer(Configuration, "pcf-steeltoe-cups-sqlserver-products"));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDiscoveryClient();

            app.UseMvc();
        }
    }
}