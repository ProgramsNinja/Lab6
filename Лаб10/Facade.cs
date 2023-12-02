using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб10
{
    internal class Facade
    {
        private Audio _audio;
        private DVD _dvd;
        private TV _tv;

        public Facade()
        {
            _audio = new Audio();
            _dvd = new DVD();
            _tv = new TV();
        }

        public void On()
        {
            Console.WriteLine("\nВключение домашнего кинотеатра:");
            _tv.On();
            _audio.On();
            _dvd.On();
            _dvd.In();
            _dvd.Play();
        }

        public void Off()
        {
            Console.WriteLine("\nВыключение домашнего кинотеатра:");
            _dvd.Out();
            _dvd.Off();
            _tv.Off();
            _audio.Off();
        }
    }
}
