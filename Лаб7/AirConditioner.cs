using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7
{
    public class AirConditioner:IRemoteControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Кондиционер включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Кондиционер выключен");
        }
        public void SetPower(int power)
        {
            Console.WriteLine($"Уровень мощности кондиционера установлен на {power}%");
        }
        public void SetMode(int mode)
        {
            Console.WriteLine($"Режим кондиционера установлен на '{mode}'");
        }
    }
}
