using Common.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public interface INumber : ILeaf, IOperationResponse
    {
        public double Value { get; set; }
    }
}
