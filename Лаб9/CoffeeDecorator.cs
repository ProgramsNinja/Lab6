using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal abstract class CoffeeDecorator : Coffee
    {

        private Coffee _coffee;


        public CoffeeDecorator(Coffee coffee, double Price, string Extra)
            : base(Price, Extra)
        {
            ArgumentNullException.ThrowIfNull(coffee);

            _coffee = coffee;
        }

        public override double Price()
        {
            return _coffee.Price() + base.Price();
        }
    }
}
