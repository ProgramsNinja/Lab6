using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб13
{
    public class OffConditionerCommand : ICommand
    {
        private Conditioner _conditioner;

        public OffConditionerCommand(Conditioner conditioner)
        {
            if (conditioner == null)
            {
                throw new ArgumentNullException(nameof(conditioner), "Кондиционер не может быть равен null.");
            }

            _conditioner = conditioner;
        }
        public void Execute()
        {
            _conditioner.Off();
        }
    }
}
