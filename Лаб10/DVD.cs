using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб10
{
    internal class DVD
    {
        public void On()
        {
            Console.WriteLine("DVD - проигрыватель включен");
        }

        public void Off()
        {
            Console.WriteLine("DVD - проигрыватель выключен");
        }

        public void In()
        {
            Console.WriteLine("Диск вставлен");
        }

        public void Out()
        {
            Console.WriteLine("Диск извлечен");
        }

        public void Play()
        {
            Console.WriteLine("Диск воспроизводится");
        }
    }
}
