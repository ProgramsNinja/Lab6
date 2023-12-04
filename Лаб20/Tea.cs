using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб20
{
    internal class Tea : DrinkBehavior
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай");
        }

        protected override void AddСomponents()
        {
            Console.WriteLine("Добавляем лимон");
        }

        protected override bool HasAdditives()
        {
            return true;
        }
    }
}
