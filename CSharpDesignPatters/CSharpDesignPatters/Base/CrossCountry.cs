﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class CrossCountry : AbstractRoadBike
    {
        public override decimal Price { get; } = 850.00m;

        public CrossCountry(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public CrossCountry(IWheel wheel)
            : this(BikeColor.Black, wheel) { }

    }
}
