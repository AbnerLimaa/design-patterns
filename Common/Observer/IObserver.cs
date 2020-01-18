using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public interface IObserver
    {
        void Update<T>(INotification<T> notification);
    }
}
