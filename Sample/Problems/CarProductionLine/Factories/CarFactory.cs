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
            ICollection<IWheel> wheels = this.WheelFactory.CreateProducts();
            ICollection<IEngine> engines = this.EngineFactory.CreateProducts();
            ICollection<ILantern> lanterns = this.LanternFactory.CreateProducts();
            foreach (IWheel wheel in wheels)
            {
                foreach (IEngine engine in engines)
                {
                    foreach (ILantern lantern in lanterns)
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
