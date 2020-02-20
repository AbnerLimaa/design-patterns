using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Factory
{
    public interface IProduct
    {
        IProductId ProductId { get; }
    }
}
