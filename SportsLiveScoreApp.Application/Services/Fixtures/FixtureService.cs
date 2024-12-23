using SportsLiveScoreApp.Application.Mapping;
using SportsLiveScoreApp.Application.Models.ViewModels.Fixtures;
using SportsLiveScoreApp.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Services.Fixtures
{

    public class FixtureService
    {
        public IRequestHandler RequestHandler { get; }

        public FixtureService(IRequestHandler requestHandler)
        {
            RequestHandler = requestHandler;
        }

        public IEnumerable<ListViewModel> GetList(DateOnly filterDate)
        {
            TimeSpan cacheTime = filterDate < DateOnly.FromDateTime(DateTime.Now) ? TimeSpan.FromHours(12) : TimeSpan.FromMinutes(1);

            string url = $"https://v3.football.api-sports.io/fixtures?date={filterDate.ToString("yyyy-MM-dd")}";
            var response = RequestHandler.ExecuteReadRequest<Models.Requests.Fixtures.List.ListRequestModel, Models.Parameters.Fixtures.ListParameterModel>(url, $"fixture-list-{filterDate}", cacheTime);

            return response.ToFixtureListViewModel();
        }

        public DetailsViewModel Get(int? id)
        {
            string url = $"https://v3.football.api-sports.io/fixtures?id={id}";
            var response = RequestHandler.ExecuteReadRequest<Models.Requests.Fixtures.Details.DetailsRequestModel, Models.Parameters.Fixtures.DetailsParameterModel>(url, $"fixture-details-id-{id}", TimeSpan.FromSeconds(15)).First();

            return response.ToFixtureDetailsViewModel();
        }
    }
}
