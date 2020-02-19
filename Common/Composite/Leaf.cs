using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Composite
{
    public abstract class Leaf : IComponent
    {
        private ICollection<IComponent> components;
        private ICollection<IComponent> Components
        {
            get
            {
                if (this.components == null)
                    this.components = new List<IComponent>() { this };
                return this.components;
            }
        }

        public IOperationResponse Operation(Func<ICollection<IComponent>, IOperationArgument[], IOperationResponse> func, params IOperationArgument[] args)
        {
            return func(this.Components, args);
        }
    }
}
