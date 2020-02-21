using System;
using System.Collections.Generic;
using System.Text;
using Common.Factory;
using Sample.Problems.CarProductionLine.Products;
using Sample.Problems.CarProductionLine.Properties;

namespace Sample.Problems.CarProductionLine.Factories
{
    public class LanternFactory : ILanternFactory
    {
        public ICollection<IProduct> CreateProducts()
        {
            ICollection<IProduct> products = new List<IProduct>();
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                IProduct product = new Lantern(new ProductId(color.ToString()), color);
                products.Add(product);
            }
            return products;
        }
    }
}
