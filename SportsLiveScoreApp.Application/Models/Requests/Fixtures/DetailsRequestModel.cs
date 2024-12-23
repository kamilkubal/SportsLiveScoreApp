using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Models.Requests.Fixtures.Details
{
    public record DetailsRequestModel(Fixture fixture, League league, Teams teams, Goals goals, Score score, List<Event> events, List<Lineup> lineups, List<Statistic> statistics, List<Player> players);
    public record Assist(int? id, string name);
    public record Away(int? id, string name, string logo, bool? winner);
    public record Cards(int yellow, int red);
    public record Coach(int? id, string name, string photo);
    public record Colors(Player player, Goalkeeper goalkeeper);
    public record Dribbles(int? attempts, int? success, int? past);
    public record Duels(int? total, int? won);
    public record Event(Time time, Team team, Player player, Assist assist, string type, string detail, string comments);
    public record Extratime(object home, object away);
    public record Fixture(int? id, string referee, string timezone, DateTime date, int timestamp, Periods periods, Venue venue, Status status);
    public record Fouls(int? drawn, int? committed);
    public record Fulltime(object home, object away);
    public record Games(int? minutes, int number, string position, string rating, bool captain, bool substitute);
    public record Goalkeeper(string primary, string number, string border);
    public record Goals(int home, int away, int? total, int conceded, int? assists, int? saves);
    public record Halftime(int home, int away);
    public record Home(int? id, string name, string logo, bool? winner);
    public record League(int? id, string name, string country, string logo, object flag, int season, string round);
    public record Lineup(Team team, string formation, List<StartXI> startXI, List<Substitute> substitutes, Coach coach);
    public record Passes(int? total, int? key, string accuracy);
    public record Penalty(object home, object away, object won, object commited, int scored, int missed, int? saved);
    public record Periods(int first, int second);
    public record Player(int? id, string name, string primary, string number, string border, string pos, string grid, string photo);
    public record Player5(Team team, List<Player> players, Player player, List<Statistic> statistics);
    public record Score(Halftime halftime, Fulltime fulltime, Extratime extratime, Penalty penalty);
    public record Shots(int? total, int? on);
    public record StartXI(Player player);
    public record Statistic(Team team, List<Statistic> statistics, string type, object value, Games games, int? offsides, Shots shots, Goals goals, Passes passes, Tackles tackles, Duels duels, Dribbles dribbles, Fouls fouls, Cards cards, Penalty penalty);
    public record Status(string @long, string @short, int elapsed, object extra);
    public record Substitute(Player player);
    public record Tackles(int? total, int? blocks, int? interceptions);
    public record Team(int? id, string name, string logo, Colors colors, DateTime update);
    public record Teams(Home home, Away away);
    public record Time(int elapsed, object extra);
    public record Venue(object id, string name, string city);
}
