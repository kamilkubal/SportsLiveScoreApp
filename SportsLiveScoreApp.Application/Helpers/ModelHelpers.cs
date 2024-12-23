using SportsLiveScoreApp.Application.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Helpers
{
    public static class ModelHelpers
    {
        public static MatchStatus MapMatchStatus(string @short)
        {
            return @short switch
            {
                "NS" => MatchStatus.NotStarted,
                "1H" => MatchStatus.FirstHalf,
                "HT" => MatchStatus.Halftime,
                "2H" => MatchStatus.SecondHalf,
                "FT" => MatchStatus.Finished,
                "PST" => MatchStatus.Postponed,
                "ET" => MatchStatus.ExtraTime,
                "BT" => MatchStatus.BreakTime,
                "P" => MatchStatus.Penalty,
                "SUSP" => MatchStatus.Suspended,
                "INT" => MatchStatus.Interrupted,
                "AET" => MatchStatus.MatchFinishedAfterExtraTime,
                "PEN" => MatchStatus.MatchFinishedAfterPenalty,
                "CANC" => MatchStatus.MatchCancelled,
                "LIVE" => MatchStatus.InProgress,
                "TBD" => MatchStatus.TimeToBeDefined,
                "ABD" => MatchStatus.MatchAbandoned,
                "AWD" => MatchStatus.TechnicalLoss,
                _ => throw new NotImplementedException()
            };
        }
    }
}
