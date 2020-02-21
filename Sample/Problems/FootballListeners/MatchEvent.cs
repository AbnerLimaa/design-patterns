using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public class MatchEvent : IMatchEvent
    {
        public string Event { get; }

        public MatchEvent(string eventName)
        {
            this.Event = eventName;
        }
    }
}
