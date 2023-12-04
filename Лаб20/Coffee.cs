using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб20
{
    internal class Coffee : DrinkBehavior
    {
        protected bool _withAdditives;

        public Coffee(bool withAdditives)
        {
            this._withAdditives = withAdditives;
        }
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }
        protected override void AddСomponents()
        {
            if (_withAdditives)
            {
                Console.WriteLine("Добавляем сахар с молоком");
            }
            else
            {
                Console.WriteLine("ничего не добавляем в кофе");
            }
        }
        protected override bool HasAdditives()
        {
            return _withAdditives;
        }
    }
}
