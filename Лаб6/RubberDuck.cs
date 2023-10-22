using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    public class RubberDuck:Duck
    {

        public override void Quack()
        {
            Console.WriteLine("уточка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("уточка не летает");
        }
    }
}
