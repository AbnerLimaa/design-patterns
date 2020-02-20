using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class ChainOfResponsibilityResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.CHAIN_OF_RESPONSIBILITY);
        }

        public void Resolve(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
