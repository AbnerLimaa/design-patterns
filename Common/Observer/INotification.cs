using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public interface INotification<T>
    {
        T Data { get; }
    }
}
