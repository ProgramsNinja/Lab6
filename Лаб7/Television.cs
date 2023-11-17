using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7
{
    public class Television:IRemoteControl
    {
        public void TurnOn() 
        {
            Console.WriteLine("Телевизор включен");
        }
        public void TurnOff() 
        { 
            Console.WriteLine("Телевизор выключен"); 
        }
        public void SetPower(int power) 
        {
            Console.WriteLine($"Уровень громкости телевизора установлен на {power}%");
        }
        public void SetMode(int mode) 
        {
            Console.WriteLine($"Режим телевизора установлен на '{mode}'");
        }
    }
}
