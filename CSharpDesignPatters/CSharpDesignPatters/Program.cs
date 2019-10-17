using CSharpDesignPatterns.AbstractFactory;
using System;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            AbstractFactoryDemo();
        }


        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeframe = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            Console.WriteLine(bikeframe.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
