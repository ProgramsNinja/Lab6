using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class WildDuck : Duck
    {
        public WildDuck()
           : base(new CanFly(), new CanQuack(), new CanSwim()) { }
    }
}
