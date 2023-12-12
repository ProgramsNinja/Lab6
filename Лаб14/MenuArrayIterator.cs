using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб14
{
    public class MenuArrayIterator : IIterator<MenuItem>
    {
        private MenuItem[] _menuItems;
        private int _position;

        public MenuArrayIterator(MenuItem[] items)
        {
            _menuItems = items;
            _position = 0;
        }
        public bool HasNext()
        {
            return _position < _menuItems.Length;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_position++];
            }
            else
            {
                throw new InvalidOperationException("Блюд больше нет");
            }
        }
    }
}
