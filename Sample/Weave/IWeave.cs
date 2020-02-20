using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave
{
    public interface IWeave
    {
        void Execute(IRequest request);
    }
}
