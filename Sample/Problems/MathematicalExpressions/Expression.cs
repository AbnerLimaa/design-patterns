using Common.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.MathematicalExpressions
{
    public class Expression : IExpression 
    {
        public IMathOperation MathOperation { get; }

        private ICollection<IComponent> components;
        public ICollection<IComponent> Components 
        { 
            get
            {
                if (this.components == null)
                    this.components = new List<IComponent>();
                return this.components;
            }
        } 

        public Expression(IMathOperation mathOperation)
        {
            this.MathOperation = mathOperation;
        }

        public IOperationResponse Operation(params IOperationArgument[] args)
        {
            INumber result = new Number(0);
            IList<INumber> numbers = new List<INumber>();
            foreach (IComponent component in this.Components)
            {
                INumber number = component.Operation(args) as INumber;
                numbers.Add(number);
            }
            result.Value = this.MathOperation.Calculate(numbers).Value;
            return result;
        }

        public void Add(IComponent component)
        {
            this.Components.Add(component);
        }

        public void Remove(IComponent component)
        {
            this.Components.Remove(component);
        }
    }
}
