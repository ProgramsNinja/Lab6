using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Lemon : CoffeeDecorator
    {
        public Lemon(Coffee coffee)
        : base(coffee, 1, "+лемон")
        { }
    }
}
