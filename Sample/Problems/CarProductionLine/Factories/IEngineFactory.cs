using Common.Factory;
using Sample.Problems.CarProductionLine.Products;
using Sample.Problems.CarProductionLine.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Factories
{
    public interface IEngineFactory : IFactory
    {
        new ICollection<IEngine> CreateProducts();
    }
}
