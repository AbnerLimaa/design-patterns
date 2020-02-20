using Common.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public interface IExpression : IComposite
    {
        IMathOperation MathOperation { get; }

        ICollection<IComponent> Components { get; }
    }
}
