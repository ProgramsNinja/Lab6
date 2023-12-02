using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Syrop : CoffeeDecorator
    {
        public Syrop(Coffee coffee)
        : base(coffee, 3, "+сироп")
        { }
    }
}
