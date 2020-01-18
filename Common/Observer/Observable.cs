using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public abstract class Observable : IObservable
    {
        private ICollection<IObserver> observers;

        public ICollection<IObserver> Observers
        {
            get
            {
                if (this.observers == null)
                    this.observers = new List<IObserver>();
                return this.observers;
            }
        }

        public void AddObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Notify<T>(INotification<T> notification)
        {
            foreach(IObserver observer in Observers)
            {
                observer.Update(notification);
            }
        }
    }
}
