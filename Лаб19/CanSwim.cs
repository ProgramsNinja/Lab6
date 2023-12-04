using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class CanSwim:ISwim
    {
        public void Swim() 
        {
            Console.WriteLine("умеет плавать");
        }
    }
}
