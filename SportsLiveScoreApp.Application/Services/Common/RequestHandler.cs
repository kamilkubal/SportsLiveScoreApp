using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SportsLiveScoreApp.Application.Models.Common;
using System.Text.Json;

namespace SportsLiveScoreApp.Application.Services.Common
{
    public class RequestHandler : IRequestHandler
    {
        public IMemoryCache Cache { get; }
        public IConfiguration Configuration { get; }

        public RequestHandler(IMemoryCache cache, IConfiguration configuration)
        {
            Cache = cache;
            Configuration = configuration;
        }

        IEnumerable<TRequestModel> IRequestHandler.ExecuteReadRequest<TRequestModel, TRequestParameter>(string url, string cacheName, TimeSpan cacheDuration)
        {
            if (!Cache.TryGetValue(cacheName, out string? responseContent) || string.IsNullOrEmpty(cacheName))
            {
                using (HttpClient client = new HttpClient())
                {
                    var apiKey = Configuration.GetSection("ApiSettings:ApiKey").Value;

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
                    client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");

                    var response = client.GetAsync(url).Result;
                    responseContent = response.Content.ReadAsStringAsync().Result;
                }
            }

            return JsonSerializer.Deserialize<Root<TRequestModel, TRequestParameter>>(responseContent).response;
        }
    }
}
