﻿using Microsoft.AspNetCore.Mvc;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}