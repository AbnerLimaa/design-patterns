using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Observer
{
    public class Notification<T> : INotification<T>
    {
        public T Data { get; }

        public Notification(T data)
        {
            this.Data = data;
        }
    }
}
