using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Composite
{
    public abstract class Composite : IComponent
    {
        private ICollection<IComponent> components;
        private ICollection<IComponent> Components 
        { 
            get
            {
                if (this.components == null)
                    this.components = new List<IComponent>();
                return this.components;
            }
        }

        public IOperationResponse Operation(Func<ICollection<IComponent>, IOperationArgument[], IOperationResponse> func, params IOperationArgument[] args)
        {
            return func(this.Components, args);
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
