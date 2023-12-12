using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб13
{
    public class CloseDoorCommand : ICommand
    {
        private Door _door;
        public CloseDoorCommand(Door door)
        {
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Дверь не может быть равна null.");
            }
            _door = door;
        }
        public void Execute()
        {
            _door.Close();
        }
    }
}
