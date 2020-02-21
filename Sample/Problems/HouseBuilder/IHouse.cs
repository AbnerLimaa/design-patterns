using Common.Builder;
using Sample.Problems.HouseBuilder.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder
{
    public interface IHouse : IBuilderResult
    {
        ICollection<IBathRoom> BathRooms { get; set; }

        ICollection<IBedRoom> BedRooms { get; set; }

        IKitchen Kitchen { get; set; }

        IGarage Garage { get; set; }
    }
}
