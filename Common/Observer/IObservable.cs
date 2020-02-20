using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public interface IObservable
    {
        ICollection<IObserver> Observers { get; } 

        void AddObserver(IObserver observer);

        void Notify<T>(INotification<T> notification);
    }
}
