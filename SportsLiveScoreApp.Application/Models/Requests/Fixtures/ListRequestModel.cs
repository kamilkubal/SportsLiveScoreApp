using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Models.Requests.Fixtures.List
{
    public record ListRequestModel(Fixture fixture, League league, Teams teams, Goals goals, Score score);
    public record Fixture(int? id, string referee, string timezone, DateTime date, int timestamp, Periods periods, Venue venue, Status status);
    public record Periods(int? first, int? second);
    public record Venue(int? id, string name, string city);
    public record Status(string @long, string @short, int? elapsed, int? extra);
    public record League(int? id, string name, string country, string logo, string flag, int season, string round);
    public record Teams(Home home, Away away);
    public record Home(int? id, string name, string logo, bool? winner);
    public record Away(int? id, string name, string logo, bool? winner);
    public record Goals(int? home, int? away);
    public record Score(Halftime halftime, Fulltime fulltime, Extratime extratime, Penalty penalty);
    public record Halftime(int? home, int? away);
    public record Fulltime(int? home, int? away);
    public record Extratime(int? home, int? away);
    public record Penalty(int? home, int? away);
}
