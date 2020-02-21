using Common.Factory;
using Sample.Problems.CarProductionLine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Factories
{
    public class CarFactory : ICarFactory
    {
        public IWheelFactory WheelFactory { get; }

        public IEngineFactory EngineFactory { get; }

        public ILanternFactory LanternFactory { get; }

        public CarFactory(IWheelFactory wheelFactory, IEngineFactory engineFactory, ILanternFactory lanternFactory)
        {
            this.WheelFactory = wheelFactory;
            this.EngineFactory = engineFactory;
            this.LanternFactory = lanternFactory;
        }

        public ICollection<IProduct> CreateProducts()
        {
            ICollection<IProduct> cars = new List<IProduct>();
            ICollection<IProduct> wheels = this.WheelFactory.CreateProducts();
            ICollection<IProduct> engines = this.EngineFactory.CreateProducts();
            ICollection<IProduct> lanterns = this.LanternFactory.CreateProducts();
            foreach (IProduct wheel in wheels)
            {
                foreach (IProduct engine in engines)
                {
                    foreach (IProduct lantern in lanterns)
                    {
                        IProductId id = new ProductId(string.Concat(wheel.ProductId.Id, " - ", engine.ProductId.Id, " - ", lantern.ProductId.Id));
                        ICar car = new Car(id, wheel, engine, lantern);
                        cars.Add(car);
                    }
                }
            }
            return cars;
        }
    }
}
