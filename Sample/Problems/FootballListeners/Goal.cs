using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public class Goal : IGoal
    {
        public ITeam Team { get; }

        public string Event
        {
            get
            {
                return "Goal";
            }
        }

        public Goal(ITeam team)
        {
            this.Team = team;
        }
    }
}
