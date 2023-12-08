using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Latte : Coffee
    {
        public Latte()
        : base("Латте ") { }

        public override double Price()
        {
            return 20;
        }
    }
}
