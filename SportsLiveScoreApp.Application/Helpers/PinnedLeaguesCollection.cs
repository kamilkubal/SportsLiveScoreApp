using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Helpers
{
    internal static class PinnedLeaguesCollection
    {
        internal static List<PinnedLeagueModel> PinnedLeagues { get; } = new List<PinnedLeagueModel>();

        static PinnedLeaguesCollection()
        {
            PinnedLeagues.AddRange(new List<PinnedLeagueModel>()
            {
                new PinnedLeagueModel() {
                    Id = 106,
                    CountryName = "Poland",
                    LeagueName = "Ekstraklasa"
                },
                new PinnedLeagueModel()
                {
                    Id = 108,
                    CountryName = "Poland",
                    LeagueName = "Cup"
                },
                new PinnedLeagueModel()
                {
                    Id = 107,
                    CountryName = "Poland",
                    LeagueName = "I Liga"
                },
                new PinnedLeagueModel()
                {
                    Id = 135,
                    CountryName = "Italy",
                    LeagueName = "Serie A"
                },
                new PinnedLeagueModel()
                {
                    Id = 140,
                    CountryName = "Spain",
                    LeagueName = "La Liga"
                },
                new PinnedLeagueModel()
                {
                    Id = 39,
                    CountryName = "England",
                    LeagueName = "Premier League"
                },
                new PinnedLeagueModel()
                {
                    Id = 61,
                    CountryName = "France",
                    LeagueName = "Ligue 1"
                },
                new PinnedLeagueModel()
                {
                    Id = 78,
                    CountryName = "Germany",
                    LeagueName = "Bundesliga"
                },
                new PinnedLeagueModel()
                {
                    Id = 5,
                    CountryName = "World",
                    LeagueName = "UEFA Nations League"
                },
                new PinnedLeagueModel()
                {
                    Id = 4,
                    CountryName = "World",
                    LeagueName = "Euro Championship"
                },
                new PinnedLeagueModel()
                {
                    Id = 1,
                    CountryName = "World",
                    LeagueName = "World Cup"
                },
                new PinnedLeagueModel()
                {
                    Id = 21,
                    CountryName = "World",
                    LeagueName = "Confederations Cup"
                },
                new PinnedLeagueModel()
                {
                    Id = 9,
                    CountryName = "World",
                    LeagueName = "Copa America"
                },
                new PinnedLeagueModel()
                {
                    Id = 2,
                    CountryName = "World",
                    LeagueName = "UEFA Champions League"
                },
                new PinnedLeagueModel()
                {
                    Id = 3,
                    CountryName = "World",
                    LeagueName = "UEFA Europa League"
                },
                new PinnedLeagueModel()
                {
                    Id = 848,
                    CountryName = "World",
                    LeagueName = "UEFA Europa Conference League"
                },
                new PinnedLeagueModel()
                {
                    Id = 7,
                    CountryName = "World",
                    LeagueName = "Asian Cup"
                },
                new PinnedLeagueModel()
                {
                    Id = 15,
                    CountryName = "World",
                    LeagueName = "FIFA Intercontinental Cup"
                },
                new PinnedLeagueModel()
                {
                    Id = 480,
                    CountryName = "World",
                    LeagueName = "Olympics Men"
                },
            });
        }

        internal static bool IsPinned(string leagueName, string countryName)
        {
            return PinnedLeagues.Any(pinnedLeague => pinnedLeague.LeagueName == leagueName && pinnedLeague.CountryName == countryName);
        }

        internal class PinnedLeagueModel
        {
            public int Id { get; set; }
            public string CountryName { get; set; }
            public string LeagueName { get; set; }
        }
    }
}
