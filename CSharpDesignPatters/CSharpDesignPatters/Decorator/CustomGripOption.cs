using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class CustomGripOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decorativeBike.Price + 20.00m; }
        }

        public CustomGripOption(IBicycle bicycle)
            :base(bicycle) { }

    }
}
