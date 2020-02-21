using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public class Team : ITeam
    {
        public string Name { get; }

        public int Goals { get; set; }

        public int BallPossession { get; set; }

        public Team(string name)
        {
            this.Name = name;
        }
    }
}
