using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Discount:CoffeeDecorator
    {
        public Discount(Coffee coffee)
        : base(coffee, (coffee.Price() * -0.07), "+скидка")
        { }
    }
}
