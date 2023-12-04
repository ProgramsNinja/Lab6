using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class CantSwim:ISwim
    {
        public void Swim()
        {
            Console.WriteLine("не умеет плавать");
        }
    }
}
