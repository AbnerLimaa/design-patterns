using System;
using System.Collections.Generic;
using System.Text;
using Common.Factory;
using Sample.Problems.CarProductionLine.Products;
using Sample.Problems.CarProductionLine.Properties;

namespace Sample.Problems.CarProductionLine.Factories
{
    public class WheelFactory : IWheelFactory
    {
        public ICollection<IWheel> CreateProducts()
        {
            ICollection<IWheel> products = new List<IWheel>();
            foreach (Dimension dimension in Enum.GetValues(typeof(Dimension)))
            {
                IWheel wheel = new Wheel(new ProductId(dimension.ToString()), dimension);
                products.Add(wheel);
            }
            return products;
        }

        ICollection<IProduct> IFactory.CreateProducts()
        {
            ICollection<IProduct> products = new List<IProduct>();
            foreach (Dimension dimension in Enum.GetValues(typeof(Dimension)))
            {
                IProduct product = new Wheel(new ProductId(dimension.ToString()), dimension);
                products.Add(product);
            }
            return products;
        }
    }
}
