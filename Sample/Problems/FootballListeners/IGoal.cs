using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public interface IGoal : IMatchEvent
    {
        public ITeam Team { get; }
    }
}
