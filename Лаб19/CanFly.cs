using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class CanFly:IFly
    {
        public void Fly()
        {
            Console.WriteLine("умеет летать");
        }
    }
}
