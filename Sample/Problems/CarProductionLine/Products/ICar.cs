using Common.Builder;
using Common.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public interface ICar : IProduct
    {
        IProduct Wheel { get; }

        IProduct Engine { get; }

        IProduct Lantern { get; }
    }
}
