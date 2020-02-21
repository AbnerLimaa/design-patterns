using Common;
using Sample.Problems.FootballListeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class ObserverResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.OBSERVER);
        }

        public void Resolve(IRequest request)
        {
            Console.WriteLine("Observer: Football Listeners Problem");

            ITeam homeTeam = new Team("Real Madrid");
            ITeam visitorTeam = new Team("Barcelona");
            Match match = new Match(homeTeam, visitorTeam);
            Narrator narrator = new Narrator(match);
            match.AddObserver(narrator);
            match.Start();
        }
    }
}
