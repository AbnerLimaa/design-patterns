using Common.Observer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Problems.FootballListeners
{
    public class Match : Observable, IMatch
    {
        public ITeam HomeTeam { get; }

        public ITeam VisitorTeam { get; }

        public bool IsHappening { get; private set; }

        public bool Ended { get; private set; }

        private Random Random { get; }

        public Match(ITeam homeTeam, ITeam visitorTeam)
        {
            this.HomeTeam = homeTeam;
            this.VisitorTeam = visitorTeam;
            this.Random = new Random();
            this.Ended = false;
        }

        public void Start()
        {
            this.FirstTime();
            this.HalfTime();
            this.SecondTime();
        }

        private void FirstTime()
        {
            this.IsHappening = true;
            this.MatchEvent(new MatchEvent("start of first time"));
            this.StartTime();
            this.IsHappening = false;
        }

        private void SecondTime()
        {
            this.IsHappening = true;
            this.MatchEvent(new MatchEvent("start of second time"));
            this.StartTime();
            this.IsHappening = false;
            this.Ended = true;
        }

        private void StartTime()
        {
            for (int i = 0; i < 45; i++)
            {
                Thread.Sleep(1 * 1000);
                this.BallPossesion();
                if (this.IsGoal(this.HomeTeam.BallPossession))
                    this.TeamGoal(this.HomeTeam);
                if (this.IsGoal(this.VisitorTeam.BallPossession))
                    this.TeamGoal(this.VisitorTeam);
            }
        }

        private void HalfTime()
        {
            int halfTime = 15;
            this.MatchEvent(new MatchEvent("half time"));
            Thread.Sleep(halfTime * 1000);         
        }

        private void BallPossesion()
        {
            this.HomeTeam.BallPossession = this.Random.Next(10, 70);
            this.VisitorTeam.BallPossession = 100 - this.HomeTeam.BallPossession;
        }

        private bool IsGoal(int ballPossesion)
        {
            if (ballPossesion > 50)
                return this.Random.Next(0, 100) < 5;
            return false;
        }

        private void TeamGoal(ITeam team)
        {
            team.Goals++;
            IGoal goal = new Goal(team);
            INotification<IGoal> notification = new Notification<IGoal>(goal);
            this.Notify(notification);
        }

        private void MatchEvent(IMatchEvent matchEvent)
        {
            INotification<IMatchEvent> notification = new Notification<IMatchEvent>(matchEvent);
            this.Notify(notification);
        }
    }
}
