using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лаб20
{
    internal abstract class DrinkBehavior
    {
        public void Make()
        {
            BoilerWater();
            Brew();
            PourIntoMug();
            AddСomponents();
        }

        public void BoilerWater()
        {
            Console.WriteLine("\nКипятим воду");
        }

        public void PourIntoMug()
        {
            Console.WriteLine("Наливаем в кружку");
        }

        protected abstract void Brew();
        protected abstract void AddСomponents();
        protected abstract bool IsAddish();
    }
}
