using Common.Builder;
using Common.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public interface ICar : IProduct
    {
        IWheel Wheel { get; }

        IEngine Engine { get; }

        ILantern Lantern { get; }
    }
}
