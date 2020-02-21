using Common.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public interface IMatch
    {
        public ITeam HomeTeam { get; }

        public ITeam VisitorTeam { get; }

        public bool IsHappening { get; }

        public bool Ended { get; }

        void Start();
    }
}
