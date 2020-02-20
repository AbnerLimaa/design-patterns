using Common.Factory;
using Sample.Problems.CarProductionLine.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public class Engine : IEngine
    {
        public IProductId ProductId { get; }

        public Power Power { get; }

        public Engine(IProductId productId, Power power)
        {
            this.ProductId = productId;
            this.Power = power;
        }
    }
}
