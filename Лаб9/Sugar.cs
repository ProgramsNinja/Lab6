using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Sugar : CoffeeDecorator
    {
        public Sugar(Coffee coffee)
          : base(coffee, 2, "+сахар")
        { }
    }
}
