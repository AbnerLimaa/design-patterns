using Common.Observer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Problems.FootballListeners
{
    public class Narrator : Observer<IMatchEvent>, INarrator
    {
        public IMatch Match { get; }

        private IDictionary<int, string> phrases;
        public IDictionary<int, string> Phrases 
        { 
            get
            {
                if (this.phrases == null)
                {
                    this.phrases = new Dictionary<int, string>();
                    this.phrases.Add(0, "This game is insane!");
                    this.phrases.Add(1, "The time is moving fast and the beard is growing up");
                    this.phrases.Add(2, "My kids sake!");
                    this.phrases.Add(3, "These two teams are playing very well");
                    this.phrases.Add(4, "Maybe the next game will be better to the home team");
                }
                return this.phrases;
            }
        }

        private Random Random { get; }

        public Narrator(IMatch match)
        {
            this.Match = match;
            this.Random = new Random();
            Task.Run(() => this.SaySomething());
        }

        private void SaySomething()
        {
            while (true)
            {
                if (this.Match.IsHappening)
                {
                    Thread.Sleep(this.Random.Next(2, 5) * 1000);
                    string phrase = string.Empty;
                    this.Phrases.TryGetValue(this.Random.Next(0, 4), out phrase);
                    Console.Clear();
                    Console.WriteLine(phrase);
                    this.Score();
                }
                else if (this.Match.Ended)
                    break;
            }
        }

        public override bool Update<E>(INotification<E> notification)
        {
            if (base.Update(notification))
            {
                if (base.Notification is INotification<IGoal>)
                    this.GoalHappened(base.Notification as INotification<IGoal>);
                if (base.Notification is INotification<IMatchEvent>)
                    this.MatchEvent(base.Notification);
                return true;
            }
            return false;
        }

        private void GoalHappened(INotification<IGoal> notification)
        {
            Console.Clear();
            Console.WriteLine("What a goal from " + notification.Data.Team.Name + "!");
            this.Score();
        }

        private void MatchEvent(INotification<IMatchEvent> notification)
        {
            Console.Clear();
            Console.WriteLine(notification.Data.Event);
        }

        private void Score()
        {
            Console.WriteLine(this.Match.HomeTeam.Name + " " + this.Match.HomeTeam.Goals + "x" + this.Match.VisitorTeam.Goals + " " + this.Match.VisitorTeam.Name);
        }
    }
}
