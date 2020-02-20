using Common.Factory;
using Sample.Problems.CarProductionLine.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public class Lantern : ILantern
    {
        public IProductId ProductId { get; }

        public Color Color { get; }

        public Lantern(IProductId productId, Color color)
        {
            this.ProductId = productId;
            this.Color = color;
        }
    }
}
