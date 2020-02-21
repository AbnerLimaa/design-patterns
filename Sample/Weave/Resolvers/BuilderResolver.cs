using Common;
using Sample.Problems.HouseBuilder;
using Sample.Problems.HouseBuilder.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class BuilderResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.BUILDER);
        }

        public void Resolve(IRequest request)
        {
            Console.WriteLine("Builder: House Builder Problem");

            IHouseBuilder houseBuilder = new HouseBuilder();
            IEngineer engineer = new Engineer(houseBuilder);
            IHouse house = engineer.BuildHouse();

            Console.WriteLine("\nBedrooms:");
            foreach (IBedRoom bedRoom in house.BedRooms)
                Console.WriteLine(bedRoom.Name);

            Console.WriteLine("\nBathrooms:");
            foreach (IBathRoom bathRoom in house.BathRooms)
                Console.WriteLine(bathRoom.Name);

            Console.WriteLine("\nGarage:");
            Console.WriteLine(house.Garage.Name);

            Console.WriteLine("\nKitchen:");
            Console.WriteLine(house.Kitchen.Name);
        }
    }
}
