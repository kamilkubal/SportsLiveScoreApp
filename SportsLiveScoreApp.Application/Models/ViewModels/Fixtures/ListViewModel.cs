using SportsLiveScoreApp.Application.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Models.ViewModels.Fixtures
{
    public class ListViewModel
    {
        public bool IsPinned { get; set; }
        public int LeagueId { get; set; }
        public string CountryName { get; set; }
        public string LeagueName { get; set; }
        public string RoundName { get; set; }
        public string CountryFlagUrl { get; set; }
        public List<ItemsViewModel> Items { get; set; }
    }

    public class ItemsViewModel
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public string HomeBrandUrl { get; set; }
        public string AwayBrandUrl { get; set; }
        public GoalViewModel Goals { get; set; }
        public FullTimeViewModel FullTime { get; set; }
        public HalfTimeViewModel HalfTime { get; set; }
        public StatusViewModel Status { get; set; }
    }

    public class FullTimeViewModel
    {
        public int? Home { get; set; }
        public int? Away { get; set; }
    }

    public class HalfTimeViewModel
    {
        public int? Home { get; set; }
        public int? Away { get; set; }
    }

    public class StatusViewModel
    {
        public MatchStatus MatchStatus { get; set; }
        public string Long { get; set; }
        public string Short { get; set; }
        public int? Elapsed { get; set; }
        public int? Extra { get; set; }
    }
}
