using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave
{
    public interface IResolver
    {
        void Resolve(IRequest request);

        bool HasLinkTo(IRequest request);
    }
}
