using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб20
{
    internal class Coffee : DrinkBehavior
    {
        private bool _withAdditives;

        public Coffee(bool withAdditives)
        {
            _withAdditives = withAdditives;
        }
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }
        protected override void AddСomponents()
        {
            if (IsAddish())
            {
                Console.WriteLine("Добавляем сахар с молоком");
            }
            else
            {
                Console.WriteLine("ничего не добавляем в кофе");
            }
        }
        protected override bool IsAddish()
        {
            return _withAdditives;
        }
    }
}
