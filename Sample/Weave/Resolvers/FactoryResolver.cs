using Common;
using Common.Factory;
using Sample.Problems.CarProductionLine.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Weave.Resolvers
{
    public class FactoryResolver : IResolver
    {
        public bool HasLinkTo(IRequest request)
        {
            return request.Id.Equals(DesignPatternId.FACTORY);
        }

        public void Resolve(IRequest request)
        {
            Console.WriteLine("Factory: Car Production Line Problem");
            IWheelFactory wheelFactory = new WheelFactory();
            IEngineFactory engineFactory = new EngineFactory();
            ILanternFactory lanternFactory = new LanternFactory();
            ICarFactory carFactory = new CarFactory(wheelFactory, engineFactory, lanternFactory);
            ICollection<IProduct> cars = carFactory.CreateProducts();
            foreach (IProduct car in cars)
            {
                Console.WriteLine(car.ProductId.Id);
            }
        }
    }
}
