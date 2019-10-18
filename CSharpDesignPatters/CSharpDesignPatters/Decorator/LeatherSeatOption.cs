﻿using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class LeatherSeatOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decorativeBike.Price + 40.00m; }
        }

        public LeatherSeatOption(IBicycle bicycle)
            : base (bicycle) { }
    }
}
