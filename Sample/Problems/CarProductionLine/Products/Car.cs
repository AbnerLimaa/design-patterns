using Common.Factory;

namespace Sample.Problems.CarProductionLine.Products
{
    public class Car : ICar
    {
        public IProductId ProductId { get; }

        public IProduct Wheel { get; }

        public IProduct Engine { get; }

        public IProduct Lantern { get; }

        public Car(IProductId productId, IProduct wheel, IProduct engine, IProduct lantern)
        {
            this.ProductId = productId;
            this.Wheel = wheel;
            this.Engine = engine;
            this.Lantern = lantern;
        }
    }
}
