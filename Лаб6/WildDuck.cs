using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    public class WildDuck:Duck
    {
        public override void Quack()
        {
            Console.WriteLine("утка крячет");
        }

        public override void Fly()
        {
            Console.WriteLine("утка летает");
        }
    }
}
