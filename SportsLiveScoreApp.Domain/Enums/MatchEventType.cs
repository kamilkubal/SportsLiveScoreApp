using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Domain.Enums
{
    public enum MatchEventType
    {
        Goal,
        YellowCard,
        RedCard,
        Substitution,
        Var,
        ScoredPenalty,
        MissedPenalty
    }
}
