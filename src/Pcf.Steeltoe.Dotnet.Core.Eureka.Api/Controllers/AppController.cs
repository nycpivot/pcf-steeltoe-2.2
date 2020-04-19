﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using System;

namespace Pcf.Steeltoe.Dotnet.Core.Eureka.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class AppController : Controller
    {
        private readonly CloudFoundryApplicationOptions appOptions;

        public AppController(
            IOptions<CloudFoundryApplicationOptions> appOptions)
        {
            this.appOptions = appOptions.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(appOptions);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            Environment.Exit(-1);

            return NoContent();
        }
    }
}