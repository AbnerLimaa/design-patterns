using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
