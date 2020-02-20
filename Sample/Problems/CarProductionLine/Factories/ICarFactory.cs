using Common.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Problems.CarProductionLine.Factories
{
    public interface ICarFactory : IFactory
    {
        IWheelFactory WheelFactory { get; }

        IEngineFactory EngineFactory { get; }

        ILanternFactory LanternFactory { get; }
    }
}
