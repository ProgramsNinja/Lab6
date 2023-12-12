using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб14
{
    public class MenuReverseListIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _position;

        public MenuReverseListIterator(List<MenuItem> items)
        {
            _menuItems = items;
            _position = items.Count - 1;
        }
        public bool HasNext()
        {
            return _position >= 0;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_position--];
            }
            else
            {
                throw new InvalidOperationException("Больше нет блюд");
            }
        }
    }

}
