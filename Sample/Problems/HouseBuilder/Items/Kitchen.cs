using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder.Items
{
    public class Kitchen : IKitchen
    {
        public string Name { get; }

        public Kitchen(string name)
        {
            this.Name = name;
        }
    }
}
