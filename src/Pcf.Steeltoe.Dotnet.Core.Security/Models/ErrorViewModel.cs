using System;

namespace Pcf.Steeltoe.Dotnet.Core.Security.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}