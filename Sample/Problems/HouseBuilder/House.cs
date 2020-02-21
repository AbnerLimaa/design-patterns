using System;
using System.Collections.Generic;
using System.Text;
using Common.Builder;
using Sample.Problems.HouseBuilder.Items;

namespace Sample.Problems.HouseBuilder
{
    public class House : IHouse
    {
        public ICollection<IBathRoom> BathRooms { get; set; }

        public ICollection<IBedRoom> BedRooms { get; set; }

        public IKitchen Kitchen { get; set; }

        public IGarage Garage { get; set; }

        public ICollection<IBuilderItem> Items { get; set; }
    }
}
