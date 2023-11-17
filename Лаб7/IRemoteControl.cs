using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7
{
    public interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetPower(int power);
        void SetMode(int mode);
    }
}
