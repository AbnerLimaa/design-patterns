using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder.Items
{
    public class Garage : IGarage
    {
        public string Name { get; }

        public Garage(string name)
        {
            this.Name = name;
        }
    }
}
