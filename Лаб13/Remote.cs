using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб13
{
    public class Remote
    {
        private Dictionary<int, ICommand> _commands = new Dictionary<int, ICommand>();
        private Stack<ICommand> _undoStack = new Stack<ICommand>();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            _commands.Add(number, remult);
            _undoStack.Push(undo);
        }
        public void Execute(int number)
        {
            if (_commands.ContainsKey(number))
            {
                ICommand remult = _commands[number];
                remult.Execute();
            }
            else
            {
                throw new ArgumentException("Кнопка не найдена", nameof(number));
            }
        }
        public void Undo()
        {
            if (_undoStack.Count > 0)
            {

                ICommand command = _undoStack.Pop();
                command.Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}
