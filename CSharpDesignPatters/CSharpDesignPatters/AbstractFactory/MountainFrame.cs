﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class MountainFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for Mountain Bike"; }
        }
    }
}
