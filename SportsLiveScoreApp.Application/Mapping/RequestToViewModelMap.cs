using SportsLiveScoreApp.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Mapping
{
    internal static class RequestToViewModelMap
    {
        internal static IEnumerable<Models.ViewModels.Fixtures.ListViewModel> ToFixtureListViewModel(this IEnumerable<Models.Requests.Fixtures.List.ListRequestModel> model)
        {
            return model.GroupBy(e => new { e.league.country, e.league.name, e.league.round }).Select(f => new Models.ViewModels.Fixtures.ListViewModel()
            {
                IsPinned = PinnedLeaguesCollection.IsPinned(f.Key.name, f.Key.country),
                LeagueId = f.First().league.id.GetValueOrDefault(0),
                CountryName = f.Key.country,
                LeagueName = f.Key.name,
                RoundName = f.Key.round,
                CountryFlagUrl = f.First().league.flag,
                Items = f.Select(e => new Models.ViewModels.Fixtures.ItemsViewModel()
                {
                    Id = e.fixture.id.GetValueOrDefault(0),
                    Time = e.fixture.date.ToString("H:mm"),
                    Home = e.teams.home.name,
                    Away = e.teams.away.name,
                    HomeBrandUrl = e.teams.home.logo,
                    AwayBrandUrl = e.teams.away.logo,
                    Goals = new Models.ViewModels.Fixtures.GoalViewModel()
                    {
                        Home = e.goals.home,
                        Away = e.goals.away,
                    },
                    FullTime = new Models.ViewModels.Fixtures.FullTimeViewModel()
                    {
                        Home = e.score.fulltime.home,
                        Away = e.score.fulltime.away,
                    },
                    HalfTime = new Models.ViewModels.Fixtures.HalfTimeViewModel()
                    {
                        Home = e.score.halftime.home,
                        Away = e.score.halftime.away
                    },
                    Status = new Models.ViewModels.Fixtures.StatusViewModel()
                    {
                        MatchStatus = ModelHelpers.MapMatchStatus(e.fixture.status.@short),
                        Long = e.fixture.status.@long,
                        Short = e.fixture.status.@short,
                        Elapsed = e.fixture.status.elapsed,
                        Extra = e.fixture.status.extra,
                    }
                }).ToList()
            }).OrderBy(e => !e.IsPinned).ThenBy(e => e.CountryName).ThenBy(e => e.LeagueName).ThenBy(e => e.RoundName).ToList();
        }

        internal static Models.ViewModels.Fixtures.DetailsViewModel ToFixtureDetailsViewModel(this Models.Requests.Fixtures.Details.DetailsRequestModel model)
        {
            return new Models.ViewModels.Fixtures.DetailsViewModel()
            {
                HomeName = model.teams.home.name,
                AwayName = model.teams.away.name,
                StartDate = model.fixture.date,
                MatchElapsed = model.fixture.status.elapsed,
                MatchStatus = ModelHelpers.MapMatchStatus(model.fixture.status.@short),
                HomeLogo = model.teams.home.logo,
                AwayLogo = model.teams.away.logo,
                Goals = new Models.ViewModels.Fixtures.GoalViewModel()
                {
                    Home = model.goals.home,
                    Away = model.goals.away,
                }
            };
        }
    }
}
