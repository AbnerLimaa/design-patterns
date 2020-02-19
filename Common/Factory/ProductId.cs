using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Factory
{
    public class ProductId : IProductId
    {
        public string Id { get; }

        public ProductId(string id)
        {
            this.Id = id;
        }
    }
}
