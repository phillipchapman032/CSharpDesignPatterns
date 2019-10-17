using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public abstract class AbstractMountainBike : AbstractRoadBike
    {
        public override decimal Price { get; } = 740.00m;

        public AbstractMountainBike(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public AbstractMountainBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel) { }

    }
}
