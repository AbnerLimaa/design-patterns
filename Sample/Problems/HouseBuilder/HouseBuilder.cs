using System;
using System.Collections.Generic;
using System.Text;
using Common.Builder;
using Sample.Problems.HouseBuilder.Items;

namespace Sample.Problems.HouseBuilder
{
    public class HouseBuilder : IHouseBuilder
    {
        private IHouse house;
        private IHouse House 
        {
            get
            {
                if (this.house == null)
                    this.house = new House();
                return this.house;
            }
        }

        public IHouseBuilder AddBathRoom(IBathRoom bathRoom)
        {
            if (this.House.BathRooms == null)
                this.House.BathRooms = new List<IBathRoom>();
            this.House.BathRooms.Add(bathRoom);
            return this;
        }

        public IHouseBuilder AddBedRoom(IBedRoom bedRoom)
        {
            if (this.House.BedRooms == null)
                this.House.BedRooms = new List<IBedRoom>();
            this.House.BedRooms.Add(bedRoom);
            return this;
        }

        public IHouseBuilder AddGarage(IGarage garage)
        {
            this.House.Garage = garage;
            return this;
        }

        public IHouseBuilder AddKitchen(IKitchen kitchen)
        {
            this.House.Kitchen = kitchen;
            return this;
        }

        public IBuilder AddItem(IBuilderItem item)
        {
            if (this.House.Items == null)
                this.House.Items = new List<IBuilderItem>();
            this.House.Items.Add(item);
            return this;
        }

        public IBuilderResult Build()
        {
            return this.House;
        }
    }
}
