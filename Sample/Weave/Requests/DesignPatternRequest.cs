using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Requests
{
    public class DesignPatternRequest : IRequest
    {
        public DesignPatternId Id { get; }

        public DesignPatternRequest(DesignPatternId id)
        {
            this.Id = id;
        }
    }
}
