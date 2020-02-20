using Sample.Weave.Resolvers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave
{
    public class WeaveConfig : IWeave
    {
        private ICollection<IResolver> resolvers;
        private ICollection<IResolver> Resolvers 
        { 
            get
            {
                if (this.resolvers == null)
                    this.resolvers = new List<IResolver>();
                return this.resolvers;
            }
        }

        public WeaveConfig()
        {
            this.ConfigWeave();
        }

        public void Execute(IRequest request)
        {
            foreach (IResolver resolver in this.Resolvers)
            {
                if (resolver.HasLinkTo(request))
                    resolver.Resolve(request);
            }
        }

        private void ConfigWeave()
        {
            this.Resolvers.Add(new AdapterResolver());
            this.Resolvers.Add(new BridgeResolver());
            this.Resolvers.Add(new BuilderResolver());
            this.Resolvers.Add(new ChainOfResponsibilityResolver());
            this.Resolvers.Add(new CommandResolver());
            this.Resolvers.Add(new CompositeResolver());
            this.Resolvers.Add(new DecoratorResolver());
            this.Resolvers.Add(new FacadeResolver());
            this.Resolvers.Add(new FactoryResolver());
            this.Resolvers.Add(new FlyweightResolver());
            this.Resolvers.Add(new InterpreterResolver());
            this.Resolvers.Add(new IteratorResolver());
            this.Resolvers.Add(new MediatorResolver());
            this.Resolvers.Add(new MementoResolver());
            this.Resolvers.Add(new ObserverResolver());
            this.Resolvers.Add(new PrototypeResolver());
            this.Resolvers.Add(new ProxyResolver());
            this.Resolvers.Add(new SingletonResolver());
            this.Resolvers.Add(new StateResolver());
            this.Resolvers.Add(new StrategyResolver());
            this.Resolvers.Add(new TemplateMethodResolver());
            this.Resolvers.Add(new VisitorResolver());
        }
    }
}
