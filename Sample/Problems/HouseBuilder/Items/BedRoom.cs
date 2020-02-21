using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder.Items
{
    public class BedRoom : IBedRoom
    {
        public string Name { get; }

        public BedRoom(string name)
        {
            this.Name = name;
        }
    }
}
