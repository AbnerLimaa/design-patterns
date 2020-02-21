using System;
using System.Collections.Generic;
using System.Text;
using Common.Factory;
using Sample.Problems.CarProductionLine.Products;
using Sample.Problems.CarProductionLine.Properties;

namespace Sample.Problems.CarProductionLine.Factories
{
    public class EngineFactory : IEngineFactory
    {
        public ICollection<IProduct> CreateProducts()
        {
            ICollection<IProduct> products = new List<IProduct>();
            foreach (Power power in Enum.GetValues(typeof(Power)))
            {
                IProduct product = new Engine(new ProductId(power.ToString()), power);
                products.Add(product);
            }
            return products;
        }
    }
}
