using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7
{
    public class RemoteControl
    {
        protected IRemoteControl Remote { get; private set; }
        public int Power { get;  set; }
        public int Mode { get;  set; }

        public RemoteControl(IRemoteControl Remote)
        {
            ArgumentNullException.ThrowIfNull(nameof(Remote));
            this.Remote = Remote;
        }

        public void TurnOn() 
        {
            Remote.TurnOn();
        }
        public void TurnOff() 
        {
            Remote.TurnOff();
        }
        public virtual void PowerPlus() 
        { 
            Remote.SetPower(++Power);
        }
        public virtual void PowerMinus()
        {
            Remote.SetPower(--Power);
        }
        public virtual void ModeNext()
        {
            Remote.SetMode(++Mode);
        } public virtual void ModePrevious()
        {
            Remote.SetMode(++Mode);
        }
    }
}
