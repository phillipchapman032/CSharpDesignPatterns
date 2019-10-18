﻿using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decorativeBike;
        

        public AbstractBikeOption(IBicycle bicycle)
            : base (bicycle.GetWheel)
        {
            this.decorativeBike = bicycle;
        }
    }
}
