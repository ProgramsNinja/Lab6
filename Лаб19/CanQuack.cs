using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class CanQuack:IQuack
    {
        public void Quack()
        {
            Console.WriteLine("умеет крякать");
        }
    }
}
