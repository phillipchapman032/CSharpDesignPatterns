using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    interface IBicycle
    {
        IWheel GetWheel { get; }

        BikeColor ColorType { get; }

        decimal Price { get; }

        void Paint(BikeColor color);
    }

}
