using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder.Items
{
    public class BathRoom : IBathRoom
    {
        public string Name { get; }

        public BathRoom(string name)
        {
            this.Name = name;
        }
    }
}
