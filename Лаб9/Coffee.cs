using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    internal abstract class Coffee
    {
        private string _description;

        public Coffee(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Описание кофе не может быть пустым или равным null", nameof(description));
            }
            _description = description;
        }

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Price();
    }
}
