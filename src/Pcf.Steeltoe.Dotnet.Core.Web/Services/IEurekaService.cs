using Steeltoe.Extensions.Configuration.CloudFoundry;
using System.Threading.Tasks;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Services
{
    public interface IEurekaService
    {
        Task<CloudFoundryApplicationOptions> GetAppInfo();
        void Crash();
    }
}