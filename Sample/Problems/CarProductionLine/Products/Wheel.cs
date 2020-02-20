using Common.Factory;
using Sample.Problems.CarProductionLine.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public class Wheel : IWheel
    {
        public IProductId ProductId { get; }

        public Dimension Dimension { get; }

        public Wheel(IProductId productId, Dimension dimension)
        {
            this.ProductId = productId;
            this.Dimension = dimension;
        }
    }
}
