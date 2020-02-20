using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class BuilderResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.BUILDER);
        }

        public void Resolve(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
