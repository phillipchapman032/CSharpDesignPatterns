﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public abstract class AbstractBike : IBicycle 
    {
        public IWheel GetWheel { get; }
        public BikeColor ColorType { get; private set; }
        public abstract decimal Price { get; }

        public AbstractBike (BikeColor color, IWheel wheel)
        {
            ColorType = color;
            GetWheel = wheel;
        }

        public AbstractBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel) { }

        public virtual void Paint (BikeColor color)
        {
            ColorType = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle color is " + ColorType +
                " and costs $" + Price;
        }
    }
}
