using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб14
{
    public class MenuVeganIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _position;

        public MenuVeganIterator(List<MenuItem> items)
        {
            _menuItems = items;
            _position = 0;
        }
        public bool HasNext()
        {
            while (_position < _menuItems.Count && !_menuItems[_position].IsVegan)
            {
                _position++;
            }
            return _position < _menuItems.Count;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_position++];
            }
            else
            {
                throw new InvalidOperationException("Больше нет веганских блюд");
            }
        }
    }
}
