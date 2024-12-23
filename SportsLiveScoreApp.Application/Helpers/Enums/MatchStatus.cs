using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Helpers.Enums
{
    public enum MatchStatus
    {
        NotStarted,
        FirstHalf,
        Halftime,
        SecondHalf,
        Finished,
        Postponed,
        MatchCancelled,
        ExtraTime,
        BreakTime,
        Penalty,
        Suspended,
        Interrupted,
        MatchFinishedAfterExtraTime,
        MatchFinishedAfterPenalty,
        InProgress,
        TimeToBeDefined,
        MatchAbandoned,
        TechnicalLoss
    }
}
