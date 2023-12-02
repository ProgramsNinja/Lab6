using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal abstract class Coffee
    {
        private double _price;
        private string _name;
        public Coffee(double price, string name)
        {
            _name += name;
            _price = price;
        }

        public virtual double Price()
        {
            return _price;
        }

        public virtual string OrderLine()
        {
            return _name;
        }
    }
}
