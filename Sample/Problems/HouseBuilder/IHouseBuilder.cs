using Common.Builder;
using Sample.Problems.HouseBuilder.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder
{
    public interface IHouseBuilder : IBuilder
    {
        IHouseBuilder AddBathRoom(IBathRoom bathRoom);

        IHouseBuilder AddBedRoom(IBedRoom bedRoom);

        IHouseBuilder AddGarage(IGarage garage);

        IHouseBuilder AddKitchen(IKitchen kitchen);
    }
}
