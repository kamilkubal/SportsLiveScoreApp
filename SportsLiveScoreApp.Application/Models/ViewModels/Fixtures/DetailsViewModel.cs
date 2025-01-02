using SportsLiveScoreApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Models.ViewModels.Fixtures
{
    public class DetailsViewModel
    {
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public DateTime StartDate { get; set; }
        public int? MatchElapsed { get; set; }
        public MatchStatus MatchStatus { get; set; }
        public string HomeLogo { get; set; }
        public string AwayLogo { get; set; }
        public GoalViewModel Goals { get; set; }
    }

    public class EventViewModel
    {
        public TimeViewModel Time { get; }
        public TeamViewModel Team { get; }
        public PlayerViewModel Player { get; }
        public AssistViewModel Assist { get; }
        public MatchEventType EventType { get; }
        public string Detail { get; }
        public string Comments { get; }
        public MatchDurationType DurationType { get; }
    }

    public class GoalViewModel
    {
        public int? Home { get; set; }
        public int? Away { get; set; }
    }

    public class TimeViewModel
    {
        public int? Elapsed { get; set; }
        public int? Extra { get; set; }
    }

    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }

    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public string Position { get; set; }
    }

    public class AssistViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
