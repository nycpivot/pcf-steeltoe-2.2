using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Models
{
    public class CupsOptions : AbstractServiceOptions
    {
        public CupsOptions() { }
        public CupsOptionsCredentials Credentials { get; set; }
    }
}