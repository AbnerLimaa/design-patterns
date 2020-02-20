using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public interface IMathOperation
    {
        INumber Calculate(IList<INumber> list);
    }
}
