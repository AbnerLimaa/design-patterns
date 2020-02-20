using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public class Subtraction : IMathOperation
    {
        public INumber Calculate(IList<INumber> list)
        {
            INumber result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result.Value -= list[i].Value;
            }
            return result;
        }
    }
}
