using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public interface IObserver
    { 
        bool Update<T>(INotification<T> notification);
    }
}
