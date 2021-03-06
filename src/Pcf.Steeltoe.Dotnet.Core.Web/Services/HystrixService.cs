﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pcf.Steeltoe.Dotnet.Core.Web.Models;
using Steeltoe.Common.Discovery;

namespace Pcf.Steeltoe.Dotnet.Core.Web.Services
{
    public class HystrixService : IHystrixService
    {
        private readonly HttpClient http;

        public HystrixService(IDiscoveryClient client)
        {
            var handler = new DiscoveryHttpClientHandler(client);

            this.http = new HttpClient(handler, false);
        }

        public async Task<IEnumerable<ProductViewModel>> GetWishlist()
        {
            var url = "http://pcf-steeltoe-dotnet-core-hystrix-api/default";

            var response = http.GetAsync(url).Result;
            var json = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<IEnumerable<ProductViewModel>>(json);

            return model;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            var url = "http://pcf-steeltoe-dotnet-core-hystrix-fallback-api/default";

            var response = http.GetAsync(url).Result;
            var json = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<IEnumerable<ProductViewModel>>(json);

            return model;
        }

        public void Crash()
        {
            var url = "http://pcf-steeltoe-dotnet-core-hystrix-api/default";

            http.DeleteAsync(url);
        }
    }
}