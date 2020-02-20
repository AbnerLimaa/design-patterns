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
            this.Resolvers.Add(new CompositeResolver());
        }
    }
}
