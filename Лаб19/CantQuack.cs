using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class CantQuack:IQuack
    {
        public void Quack()
        {
            Console.WriteLine("не умеет крякать");
        }
    }
}
