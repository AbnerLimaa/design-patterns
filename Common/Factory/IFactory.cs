using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Factory
{
    public interface IFactory
    {
        ICollection<IProduct> CreateProducts();
    }
}
