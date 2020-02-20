using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class IteratorResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.ITERATOR);
        }

        public void Resolve(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
