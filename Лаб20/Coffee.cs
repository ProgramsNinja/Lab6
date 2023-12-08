using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб20
{
    internal class Coffee : DrinkBehavior
    {
        private bool _isAddish;
        public Coffee(bool isAddish)
        {
            _isAddish = isAddish;
        }

        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }
        protected override void AddСomponents()
        {
                Console.WriteLine("Добавляем сахар с молоком");
        }
        protected override bool IsAddish()
        {
            return _isAddish;
        }
    }
}
