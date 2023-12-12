using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб13
{
    public class MultiCommand : ICommand
    {
        private readonly List<ICommand> _commandList = new List<ICommand>();

        public MultiCommand(List<ICommand> command)
        {
            _commandList.AddRange(command);
        }
        public void Execute()
        {
            foreach (ICommand command in _commandList)
            {
                command.Execute();
            }
        }
    }
}
