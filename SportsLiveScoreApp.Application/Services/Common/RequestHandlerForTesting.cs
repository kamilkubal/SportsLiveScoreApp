using Microsoft.Extensions.Caching.Memory;
using SportsLiveScoreApp.Application.Models.Common;
using SportsLiveScoreApp.Application.Models.Requests.Fixtures.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Services.Common
{
    public class RequestHandlerForTesting : IRequestHandler
    {
        public IMemoryCache cache { get; }
        public RequestHandlerForTesting(IMemoryCache cache)
        {
            this.cache = cache;
        }

        IEnumerable<TRequestModel> IRequestHandler.ExecuteReadRequest<TRequestModel, TRequestParameter>(string url, string cacheName, TimeSpan cacheDuration)
        {
            if (!cache.TryGetValue(cacheName, out string? responseContent) || string.IsNullOrEmpty(cacheName))
            {
                string filePath = string.Empty;
                //if (cacheName.Contains("details"))
                //    filePath = @"C:\Users\kamil\source\repos\FootballApi\FootballApi\DummiesData\FixtureEvents.json";
                //else
                    filePath = @"C:\Users\kamil\source\repos\SportsLiveScoreApp\SportsLiveScoreApp.Application\DummiesData\Fixtures.json";

                if (File.Exists(filePath))
                    responseContent = File.ReadAllText(filePath);

                if (!string.IsNullOrEmpty(cacheName))
                    cache.Set(cacheName, responseContent, new MemoryCacheEntryOptions()
                   .SetAbsoluteExpiration(cacheDuration));
            }

            return JsonSerializer.Deserialize<Root<TRequestModel, TRequestParameter>>(responseContent).response;
        }
    }
}
