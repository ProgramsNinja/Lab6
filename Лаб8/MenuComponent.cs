using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб8
{
    public abstract class MenuComponent
    {
        private string name;
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public MenuComponent(string name)
        {
            this.name = name;
        }

        public virtual void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }

        public virtual void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }

        public virtual void Print()
        {
            Console.WriteLine(name);

            foreach (MenuComponent component in _menuComponents)
            {
                component.Print();
            }
        }
    }
}
