using Common;
using Common.Composite;
using Sample.Problems.MathematicalExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class CompositeResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.COMPOSITE);
        }

        public void Resolve(IRequest request)
        {
            Console.WriteLine("Composite: Mathematical Expressions Problem");
            //(a + b) - (c + d)
            Number a = new Number(0);
            Number b = new Number(1);
            Number c = new Number(2);
            Number d = new Number(2);
            Expression sum1 = new Expression(new Sum());
            Expression sum2 = new Expression(new Sum());
            Expression subtraction = new Expression(new Subtraction());
            sum1.Add(a);
            sum1.Add(b);
            sum2.Add(c);
            sum2.Add(d);
            subtraction.Add(sum1);
            subtraction.Add(sum2);
            Number response = subtraction.Operation() as Number;
            Console.WriteLine(response.Value);
        }
    }
}
