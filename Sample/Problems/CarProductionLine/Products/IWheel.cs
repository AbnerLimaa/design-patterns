﻿using Common.Builder;
using Common.Factory;
using Sample.Problems.CarProductionLine.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Products
{
    public interface IWheel : IProduct
    {
        Dimension Dimension { get; }
    }
}
