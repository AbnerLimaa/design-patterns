﻿using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class StrategyResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.STRATEGY);
        }

        public void Resolve(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
