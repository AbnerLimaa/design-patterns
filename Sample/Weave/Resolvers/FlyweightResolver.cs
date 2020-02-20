using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class FlyweightResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.FLYWEIGHT);
        }

        public void Resolve(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
