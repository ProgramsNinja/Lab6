using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб14
{
    public class MenuItem
    {
        public string Name { get; set; }
        public bool IsVegan { get; set; }

        public MenuItem(string name, bool isVegan)
        {
            Name = name;
            IsVegan = isVegan;
        }
    }
}
