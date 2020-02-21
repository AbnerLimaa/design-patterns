using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public interface ITeam
    {
        public string Name { get; }

        public int Goals { get; set; }

        public int BallPossession { get; set; }
    }
}
