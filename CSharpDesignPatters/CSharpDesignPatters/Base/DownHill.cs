﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class DownHill : AbstractRoadBike
    {
        public override decimal Price { get; } = 870.00m;

        public DownHill (BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public DownHill(IWheel wheel)
            : this(BikeColor.Chrome, wheel) { }
    }
}
