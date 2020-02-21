using Sample.Problems.HouseBuilder.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.HouseBuilder
{
    public class Engineer : IEngineer
    {
        private IHouseBuilder HouseBuilder { get; set; }

        public Engineer(IHouseBuilder houseBuilder)
        {
            this.HouseBuilder = houseBuilder;
        }

        public IHouse BuildHouse()
        {
            IHouse house = this.HouseBuilder
                .AddBathRoom(new BathRoom("kids bathroom"))
                .AddBathRoom(new BathRoom("parents bathroom"))
                .AddBathRoom(new BathRoom("visitor bathroom"))
                .AddBedRoom(new BedRoom("parents bedroom"))
                .AddBedRoom(new BedRoom("kids bedroom"))
                .AddBedRoom(new BedRoom("visitor bedroom"))
                .AddGarage(new Garage("garage"))
                .AddKitchen(new Kitchen("kitchen"))
                .Build() as IHouse;
            return house;
        }
    }
}
