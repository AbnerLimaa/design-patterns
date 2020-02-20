using Common.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public class Number : INumber
    {
        public double Value { get; set; }

        public Number(double value)
        {
            this.Value = value;
        }

        public IOperationResponse Operation(params IOperationArgument[] args)
        {
            return this;
        }
    }
}
