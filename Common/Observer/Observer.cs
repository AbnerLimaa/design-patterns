using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public abstract class Observer<T> : IObserver
    {
        public INotification<T> Notification { get; protected set; }

        public virtual bool Update<E>(INotification<E> notification)
        {
            if (notification.Data is T)
            {
                this.Notification = notification as INotification<T>;
                return true;
            }
            return false;
        }
    }
}
