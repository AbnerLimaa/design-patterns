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
        public ICollection<ILantern> CreateProducts()
        {
            ICollection<ILantern> products = new List<ILantern>();
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                ILantern lantern = new Lantern(new ProductId(color.ToString()), color);
                products.Add(lantern);
            }
            return products;
        }

        ICollection<IProduct> IFactory.CreateProducts()
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
