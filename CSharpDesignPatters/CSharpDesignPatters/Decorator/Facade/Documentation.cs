﻿using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator.Facade
{
    public class Documentation
    {
        public static void PrintBrochure(IBicycle bicycle)
        {
            Console.WriteLine("Printing Brochure....");
        }
    }
}
