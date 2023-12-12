using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб13
{
    public class OffLightCommand : ICommand
    {
        private Light _light;

        public OffLightCommand(Light light)
        {
            if (light == null)
            {
                throw new ArgumentNullException(nameof(light), "Свет не может быть равен null.");
            }

            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
