using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.FootballListeners
{
    public interface INarrator
    {
        public IMatch Match { get; }

        public IDictionary<int, string> Phrases { get; }
    }
}
