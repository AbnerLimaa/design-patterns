using Common.Factory;

namespace Sample.Problems.CarProductionLine.Products
{
    public class Car : ICar
    {
        public IProductId ProductId { get; }

        public IWheel Wheel { get; }

        public IEngine Engine { get; }

        public ILantern Lantern { get; }

        public Car(IProductId productId, IWheel wheel, IEngine engine, ILantern lantern)
        {
            this.ProductId = productId;
            this.Wheel = wheel;
            this.Engine = engine;
            this.Lantern = lantern;
        }
    }
}
