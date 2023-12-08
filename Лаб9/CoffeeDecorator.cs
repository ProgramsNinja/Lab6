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
        private double _extraPrice;

        public CoffeeDecorator(Coffee coffee, double extraPrice, string descriptionAddition)
            : base(coffee.GetDescription() + descriptionAddition)
        {
            _coffee = coffee;
            _extraPrice = extraPrice;
        }

        public override double Price()
        {
            return _coffee.Price() + _extraPrice;
        }
    }
}
