using Common;
using Sample.Problems.LoadFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class SingletonResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.SINGLETON);
        }

        public void Resolve(IRequest request)
        {
            Console.WriteLine("Singleton: Load File Problem");
            Settings settings = AppSettings.INSTANCE.Settings;
            Console.WriteLine(settings.appName);
        }
    }
}
