using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator.Facade
{
    public class Registration
    {
        private IBicycle bicycle;

        public Registration (IBicycle bike)
        {
            this.bicycle = bike;
        }

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number");
        }
    }
}
